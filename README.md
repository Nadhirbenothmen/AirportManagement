# Application de Gestion des Aéroports

Cette application permet de gérer les aéroports, les vols et les informations passagers. Elle utilise ASP.NET Core et C# pour la gestion des API backend, et inclut des fonctionnalités pour enregistrer, modifier, supprimer et consulter les données sur les aéroports et les vols. 


## Fonctionnalités
- **Gestion des Aéroports** : Création, modification, suppression et consultation des aéroports.
- **Suivi des Vols** : Enregistrement des vols avec horaires, destinations et status.
- **Gestion des Passagers** : Ajout, recherche et gestion des informations des passagers.
- **Suivi en Temps Réel** : Vue des vols en temps réel avec état (en vol, atterri, retardé).
- **Rapports** : Génération de rapports sur les vols et les passagers.

## Architecture
- **ASP.NET Core** : Framework backend pour créer les API RESTful.
- **Entity Framework Core** : Gestion de la base de données pour stocker les données de l'application.
- **SQL Server** : Base de données pour le stockage des informations d’aéroports, vols et passagers.

## Prérequis
- **.NET Core SDK** : Version 5.0 ou plus récente.
- **SQL Server** : Version 2017 ou plus récente.
- **Visual Studio** : Version 2019 ou plus récente.

## Installation
1. **Clonez le dépôt :**
   ```bash
   git clone https://github.com/nom-utilisateur/gestion-des-aeroports.git
   cd gestion-des-aeroports
