# PRET_A_PORTER — Gestion de boutique

Application Windows (VB.NET / WinForms, .NET Framework 3.5, MySQL) pour une
boutique de prêt-à-porter : articles et catégories, stock, personnel,
facturation avec remises et calcul de bénéfice, utilisateurs et profils,
nombreuses éditions Crystal Reports (factures, listes d'articles, stock,
personnel, bénéfices par période).

> **English** — Retail shop management desktop app (VB.NET WinForms + MySQL).
> Articles, categories, stock, staff, invoicing with discounts and profit
> tracking, user profiles, Crystal Reports printouts. 2020 project, cleaned up
> in 2026 (parameterized login, full MySQL schema, documented configuration).

![VB.NET](https://img.shields.io/badge/VB.NET-WinForms-5C2D91)
![.NET Framework 3.5](https://img.shields.io/badge/.NET%20Framework-3.5-512BD4)
![MySQL](https://img.shields.io/badge/MySQL-5.x%20%2F%20MariaDB-4479A1)
![Licence MIT](https://img.shields.io/badge/licence-MIT-green)

## Fonctionnalités

- Société (en-tête des documents : IFU, RCCM, coordonnées)
- Articles par catégorie, avec prix d'achat, prix de vente et bénéfice unitaire ; numérotation automatique
- Stock : quantité initiale, ajouts, décrément automatique à la facturation
- Personnel (type, sexe, date d'embauche) et utilisateurs de l'application avec profil
- Caisse / facturation : lignes tampon, remise par taux, montant payé, bénéfice par article et par facture
- Recherche de factures, factures d'une période, filtre des bénéfices
- Journal des connexions utilisateurs
- États Crystal Reports : facture, liste des articles et prix, articles par catégorie, stock, personnel, bénéfices

## Installation

Prérequis : Windows, Visual Studio avec **.NET Framework 3.5** activé, MySQL 5.x+
ou MariaDB, [MySQL Connector/NET](https://dev.mysql.com/downloads/connector/net/)
(l'application référence `MySql.Data` 5.0.9 ; une version récente fonctionne en
mettant à jour la référence), runtime Crystal Reports 10.5.

```powershell
git clone https://github.com/pACCOU/PRET_A_PORTER.git
cd PRET_A_PORTER
mysql -u root -p < database\pret_a_porter.sql      # base + compte admin/admin
copy text_serveur.txt.example PRET_A_PORTER\bin\Debug\text_serveur.txt
```

Éditez `text_serveur.txt` (il doit se trouver à côté de l'exécutable) :

```
SERVER=localhost; UID=root; DATABASE=pret_a_porter; password=VOTRE_MOT_DE_PASSE
```

Ce fichier est ignoré par git (`.gitignore`) pour ne jamais versionner un mot
de passe. Ouvrir `PRET_A_PORTER.sln`, puis F5.

## Schéma de la base

Reconstruit à partir des requêtes et des formulaires —
[`database/pret_a_porter.sql`](database/pret_a_porter.sql) (14 tables :
`societe`, `profil`, `user`, `listinning`, `sexe`, `typepersonne`,
`typepersonnel`, `personne`, `categorie`, `article`, `stock`, `tauxreduction`,
`facture`, `tabletampon`, plus `crack_application` pour l'activation d'origine).

## Historique

**2026 — remise en état** : requête de connexion paramétrée, script MySQL
complet avec données de démarrage, fichier de configuration documenté et
exclu de git, `.gitignore`, licence.

**2020 — version initiale.**

## Limites connues

- Mots de passe en clair ; le mécanisme d'« activation » (`crack_application`) est un reliquat à retirer.
- Les formulaires construisent leurs requêtes par concaténation via un module générique (`MAJ.vb`) ; une version moderne passerait par des paramètres ou un ORM.
- Crystal Reports est propriétaire ; remplacer par RDLC ou une génération PDF pour un déploiement sans licence.

Licence MIT — Florian Whannou
