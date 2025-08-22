from time import sleep

from db import get_connection, insert_parlamentarian_groups, insert_legislatures
from script import get_session, get_parlamentarian_groups, get_legislatures


def main():
    url = "https://www.cdep.ro/pls/parlam/structura2015.co?leg=2024"
    urlForTheParlamentarinasGroup= "https://cdep.ro/pls/parlam/structura2015.gp?idl=1"
    headers = {
        "User-Agent": "Mozilla/5.0 (Windows NT 10.0; Win64; x64)",
        "Accept": "text/html,application/xhtml+xml"
    }

    session = get_session()
    groups = get_parlamentarian_groups(urlForTheParlamentarinasGroup, headers=headers, session=session)
    legislatures = get_legislatures(url,headers=headers,session=session)

    if not groups:
        print("⚠️ Nu s-au găsit grupuri parlamentare")
        return

    conn = get_connection()
    if groups:
        insert_parlamentarian_groups(conn, groups)
        print(f"✅ Am inserat {len(groups)} grupuri parlamentare în DB.")

    if legislatures:
        insert_legislatures(conn,legislatures)
        print(f"✅ Am inserat {len(legislatures)} legislaturi în DB.")

    conn.close()


if __name__ == "__main__":
    while True:
        sleep(5)
        main()
