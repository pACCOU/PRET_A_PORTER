-- =====================================================================
--  PRET_A_PORTER — base MySQL / MariaDB
--  Schéma reconstruit à partir des requêtes du code source.
--  Exécuter :  mysql -u root -p < pret_a_porter.sql
-- =====================================================================
CREATE DATABASE IF NOT EXISTS pret_a_porter CHARACTER SET utf8mb4;
USE pret_a_porter;

CREATE TABLE profil (
    idprofil_PK   INT AUTO_INCREMENT PRIMARY KEY,
    libelleprofil VARCHAR(50) NOT NULL
);

CREATE TABLE `user` (
    iduser_PK     INT AUTO_INCREMENT PRIMARY KEY,
    compte        VARCHAR(50)  NOT NULL UNIQUE,
    nomprenom     VARCHAR(100) NOT NULL,
    motdepasse    VARCHAR(100) NOT NULL,
    idprofil_FK   INT NOT NULL,
    idsociete_FK  INT NULL,
    idpersonne_FK INT NULL,
    FOREIGN KEY (idprofil_FK) REFERENCES profil(idprofil_PK)
);

CREATE TABLE listinning (            -- journal des connexions
    id          INT AUTO_INCREMENT PRIMARY KEY,
    iduser      INT NOT NULL,
    dateconnect DATETIME NOT NULL
);

CREATE TABLE societe (
    idsociete_PK   INT AUTO_INCREMENT PRIMARY KEY,
    libellesociete VARCHAR(100),
    adresse        VARCHAR(200),
    telephone      VARCHAR(30),
    fax            VARCHAR(30),
    email          VARCHAR(100),
    ifu            VARCHAR(50),
    RCCM           VARCHAR(50),
    nompdg         VARCHAR(100),
    raisonsociale  VARCHAR(100)
);

CREATE TABLE sexe (
    idsexe_PK INT AUTO_INCREMENT PRIMARY KEY,
    sexe      VARCHAR(10) NOT NULL
);

CREATE TABLE typepersonne (
    idtypepersonne_PK   INT AUTO_INCREMENT PRIMARY KEY,
    libelletypepersonne VARCHAR(50) NOT NULL
);

CREATE TABLE typepersonnel (
    idtypepersonnel_PK INT AUTO_INCREMENT PRIMARY KEY,
    libellepersonnel   VARCHAR(50) NOT NULL
);

CREATE TABLE personne (
    idpersonne_PK      INT AUTO_INCREMENT PRIMARY KEY,
    nompersonne        VARCHAR(50) NOT NULL,
    prenompersonne     VARCHAR(50),
    tel                VARCHAR(30),
    email              VARCHAR(100),
    dateembauche       DATE,
    idsexe_FK          INT,
    idtypepersonne_FK  INT,
    idtypepersonnel_FK INT,
    FOREIGN KEY (idsexe_FK)          REFERENCES sexe(idsexe_PK),
    FOREIGN KEY (idtypepersonne_FK)  REFERENCES typepersonne(idtypepersonne_PK),
    FOREIGN KEY (idtypepersonnel_FK) REFERENCES typepersonnel(idtypepersonnel_PK)
);

CREATE TABLE categorie (
    idcategorie_PK   INT AUTO_INCREMENT PRIMARY KEY,
    libellecategorie VARCHAR(50) NOT NULL
);

CREATE TABLE article (
    idarticle_PK     INT AUTO_INCREMENT PRIMARY KEY,
    numarticle       VARCHAR(20),
    lebellearticle   VARCHAR(100) NOT NULL,
    marquearticle    VARCHAR(50),
    taillearticle    VARCHAR(20),
    prixunitarticle  DECIMAL(12,2) DEFAULT 0,
    prixvente        DECIMAL(12,2) DEFAULT 0,
    beneficearticle  DECIMAL(12,2) DEFAULT 0,
    dateenregistrement DATE,
    idcategorie_FK   INT,
    FOREIGN KEY (idcategorie_FK) REFERENCES categorie(idcategorie_PK)
);

CREATE TABLE stock (
    idstock_PK           INT AUTO_INCREMENT PRIMARY KEY,
    idarticle_FK         INT NOT NULL,
    quantiteinitialstock INT DEFAULT 0,
    quantiteajoute       INT DEFAULT 0,
    datestock            DATE,
    FOREIGN KEY (idarticle_FK) REFERENCES article(idarticle_PK)
);

CREATE TABLE tauxreduction (
    idtauxreduction_PK INT AUTO_INCREMENT PRIMARY KEY,
    taux               DECIMAL(5,2) NOT NULL
);

CREATE TABLE facture (
    idfacture_PK        INT AUTO_INCREMENT PRIMARY KEY,
    numfact             VARCHAR(20) NOT NULL,
    nompersonne         VARCHAR(100),
    idarticle_FK        INT NOT NULL,
    quantitevendue      INT NOT NULL,
    montantreduction    DECIMAL(12,2) DEFAULT 0,
    montantfacture      DECIMAL(12,2) DEFAULT 0,
    montanthred         DECIMAL(12,2) DEFAULT 0,
    montantproduitpayer DECIMAL(12,2) DEFAULT 0,
    beneficesurart      DECIMAL(12,2) DEFAULT 0,
    beneficetotal       DECIMAL(12,2) DEFAULT 0,
    iduser_FK           INT,
    datefacture         DATE,
    FOREIGN KEY (idarticle_FK) REFERENCES article(idarticle_PK),
    FOREIGN KEY (iduser_FK)    REFERENCES `user`(iduser_PK)
);

CREATE TABLE tabletampon (           -- lignes de facture en cours de saisie
    id        INT AUTO_INCREMENT PRIMARY KEY,
    iduser_FK INT,
    numfact   VARCHAR(20),
    `date`    DATE,
    nom       VARCHAR(100)
);

-- Table de licence de l'application d'origine (activation / clé). Conservée pour
-- compatibilité ; une ligne "definitive_crak = 1" désactive la limitation.
CREATE TABLE crack_application (
    id              INT AUTO_INCREMENT PRIMARY KEY,
    date_activation DATE,
    cle_active      VARCHAR(100),
    definitive_crak TINYINT DEFAULT 0
);

INSERT INTO profil (libelleprofil) VALUES ('Administrateur'), ('Vendeur');
INSERT INTO sexe (sexe) VALUES ('Masculin'), ('Féminin');
INSERT INTO `user` (compte, nomprenom, motdepasse, idprofil_FK) VALUES ('admin', 'Administrateur', 'admin', 1);
INSERT INTO crack_application (date_activation, cle_active, definitive_crak) VALUES (CURDATE(), 'DEMO', 1);
INSERT INTO tauxreduction (taux) VALUES (0), (5), (10);
