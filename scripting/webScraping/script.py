import ssl
from bs4 import BeautifulSoup
import requests
from requests.adapters import HTTPAdapter

class TLSAdapter(HTTPAdapter):
    def init_poolmanager(self, *args, **kwargs):
        context = ssl.create_default_context()
        context.set_ciphers('DEFAULT@SECLEVEL=1')
        context.minimum_version = ssl.TLSVersion.TLSv1_2
        kwargs['ssl_context'] = context
        return super().init_poolmanager(*args, **kwargs)

def get_session():
    """
    Returnează un session Requests configurat pentru TLS.
    """
    session = requests.Session()
    session.mount('https://', TLSAdapter())
    return session

def get_parlamentarian_groups(url, headers=None, session=None):
    """
    Extrage grupurile parlamentare de pe site.
    Returnează listă de tuple [(group_name,), ...]
    """
    response = session.get(url, headers=headers)

    soup = BeautifulSoup(response.text, "lxml")
    div = soup.find("div", class_="grup-parlamentar-list grupuri-parlamentare-list")

    groups = []
    if div:
        # fiecare link din coloana a treia (<td>) reprezintă numele partidului
        rows = div.find_all("tr")
        for row in rows:
            tds = row.find_all("td")
            if len(tds) >= 3:
                a_tag = tds[2].find("a")  # coloana 3 conține numele scurt al partidului
                if a_tag:
                    groups.append((a_tag.text.strip(),))
    return groups



def get_legislatures(url, headers=None, session=None):
    """
    Extrage legislaturile de pe site.
    Returnează listă de tuple [(start_year, end_year), ...]
    """
    if session is None:
        session = get_session()

    response = session.get(url, headers=headers)
    soup = BeautifulSoup(response.text, "lxml")

    legislatures = []
    # Găsim div-ul principal unde sunt listate legislaturile
    main_menu = soup.find("div", class_="main-menu")
    if not main_menu:
        print("⚠️ Nu am găsit meniul principal cu legislaturi.")
        return legislatures

    # Căutăm toate link-urile din submeniul "Organizarea din alte legislaturi"
    submenus = main_menu.find_all("div", class_="second-dropdown")
    for submenu in submenus:
        links = submenu.find_all("a")
        for link in links:
            title = link.get("title")
            if " - " in title:
                start_year, end_year = title.split(" - ")
                legislatures.append((start_year.strip(), end_year.strip()))

    return legislatures
