from datetime import datetime

import psycopg2

def get_connection():
    """
    Returnează conexiunea la PostgreSQL.
    Modifică parametrii după setup-ul tău.
    """
    return psycopg2.connect(
        host="localhost",
        database="e_Parliament",
        user="postgres",
        password="admin"
    )

def insert_parlamentarian_groups(conn, groups):
    cursor = conn.cursor()
    for group in groups:
        cursor.execute(
            "INSERT INTO parlamentar_groups (parlamentar_group_name) VALUES (%s) ON CONFLICT DO NOTHING",
            (group[0],)  # folosim doar primul element din tuple
        )
    conn.commit()
    cursor.close()


def insert_legislatures(conn, legislatures):
    cursor = conn.cursor()
    for start_year, end_year in legislatures:
        try:
            start_year = int(start_year)
        except ValueError:
            continue  # sărim peste intrările invalide

        if end_year is not None:
            try:
                end_year = int(end_year)
            except ValueError:
                end_year = None

        start_date = datetime(start_year, 1, 1)
        end_date = datetime(end_year, 12, 31) if end_year is not None else None

        cursor.execute(
            "INSERT INTO legislatures (legislature_start, legislature_end) VALUES (%s, %s) ON CONFLICT DO NOTHING",
            (start_date, end_date)
        )
    conn.commit()
    cursor.close()

