-- Algèbre relationnelle et SQL --

-- 1 --
R1 = PROJECTION(SITE, rayon, etage)

SELECT rayon, etage
FROM site;

+-------+-------+
| rayon | etage |
+-------+-------+
| R1    |     1 |
| R2    |     1 |
| R3    |     2 |
| R4    |     2 |
| R5    |     3 |
| R6    |     4 |
+-------+-------+

-- 2 --
R1 = SELECTION(EMPLOYE, salaire ENTRE "1000,00" ET "4000,00")
R2 = PROJECTION(R1, noemp, nom)

SELECT noemp, nom
FROM employe
WHERE salaire BETWEEN "1000,00" AND "4000,00";

+-------+---------+
| noemp | nom     |
+-------+---------+
|     1 | Dupont  |
|     2 | Durand  |
|     3 | Martin  |
|     4 | Duval   |
|     5 | Legrand |
+-------+---------+

-- 3 --
R1 = JOINTURE(classe, site, classe.rayon = site.rayon)
R2 = SELECTION(R1, etage = 1)
R3 = PROJECTION(R2, *)

SELECT *
FROM classe
INNER JOIN site
ON classe.rayon = site.rayon
WHERE etage = 1;

+-------+---------+-------+-------+-------+-----------+
| noart | marque  | rayon | rayon | etage | libelle   |
+-------+---------+-------+-------+-------+-----------+
| A500  | philips | R1    | R1    |     1 | hifi      |
| A100  | bosch   | R2    | R2    |     1 | bricolage |
+-------+---------+-------+-------+-------+-----------+

-- 4 --
R1 = CUMUL(SITE,site.rayon,salaire)
R2 = JOINTURE(site, employe, site.rayon = employe.rayon)
R3 = SELECTION(R2, R1.CUMUL > 7000)
R4 = PROJECTION(R3,site.rayon)

SELECT site.rayon
FROM site
INNER JOIN employe
ON site.rayon = employe.rayon
GROUP BY rayon
HAVING SUM(salaire) > 7000;

+-------+
| rayon |
+-------+
| R4    |
| R5    |
+-------+

-- 5 --
R1 = SELECTION(employe, nom = 'Mansart')
R2 = SELECTION(employe, salaire > 3000)
R3 = PROJECTION(R1, noemp, nom)
R4 = PROJECTION(R2, noemp, nom)
R5 = UNION(R3,R4)

SELECT noemp, nom
FROM employe
WHERE salaire > 3000
OR chef = (SELECT noemp FROM employe where nom = 'Mansart');

+-------+----------+
| noemp | nom      |
+-------+----------+
|     3 | Martin   |
|     6 | Lenotre  |
|     7 | Berteaux |
|     8 | Mansart  |
+-------+----------+