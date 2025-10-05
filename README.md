# ListeProduits  
### Cours 420-3D4-MO – Interface utilisateur  

<img width="664" height="424" alt="Image" src="https://github.com/user-attachments/assets/3959979e-04b0-4556-8cd8-afcf1b0173a0" />


## Description du projet
Cette application Windows Forms permet à l’utilisateur de gérer une liste de produits.  
Chaque produit possède un nom (string) et un prix (decimal).  
L’utilisateur peut ajouter, supprimer ou effacer des produits, et le nombre total de produits est affiché automatiquement dans une zone numérique (`NumericUpDown`) en lecture seule.

Le projet a été réalisé dans le cadre du **Laboratoire de révision** du cours *Interface utilisateur*.

---

## Fonctionnalités principales

### Ajout d’un produit
- L’utilisateur entre le **nom** du produit dans une zone de texte et le **prix** dans un champ numérique.
- En cliquant sur **Ajouter**, le produit est ajouté à la liste (`ListBox`).
- Le compteur s’incrémente automatiquement.
- Le prix est arrondi à deux décimales et toujours affiché sous le format monétaire (`0.00$`).

### Suppression d’un produit
- Le bouton **Supprimer** permet de retirer un produit sélectionné dans la liste.
- Le compteur est décrémenté de 1.
- Si la liste devient vide, les boutons **Supprimer** et **Effacer** sont automatiquement désactivés.

### Effacement complet
- Le bouton **Effacer** supprime tous les éléments de la liste.
- Le compteur global est remis à zéro.

### Compteur automatique
- Le nombre total de produits est affiché dans une zone `NumericUpDown` en lecture seule.
- Il se met à jour automatiquement après chaque ajout, suppression ou effacement.

### Quitter
- Le bouton **Quitter** ferme proprement l’application.

---

## Structure du projet

### Classe `Produit`
| Élément | Description |
|----------|--------------|
| `_nom` | Nom du produit (string) |
| `_prix` | Prix du produit (decimal) |
| `_compteur` *(static)* | Compteur global partagé par tous les produits |
| `Produit(string nom, decimal prix)` | Constructeur principal avec incrément automatique |
| `Compteur` *(propriété statique)* | Retourne le nombre total de produits |
| `DecrementerCompteur()` | Diminue le compteur |
| `ReinitialiserCompteur()` | Remet le compteur à zéro |
| `ToString()` | Retourne le texte formaté du produit (`Nom - Prix$`, toujours avec deux décimales) |

### Formulaire `Form1`
- Contient la logique pour les boutons **Ajouter**, **Supprimer**, **Effacer** et **Quitter**.
- Met à jour dynamiquement les boutons selon le contenu de la liste.
- Utilise un `BindingList<Produit>` pour gérer les produits de façon réactive.

---

## Logique du compteur
- Le compteur est **statique** (lié à la classe `Produit`).
- Il s’incrémente à chaque création d’objet `Produit`.
- Il se décrémente lorsqu’un produit est supprimé.
- Il se réinitialise à zéro lors d’un effacement complet.

---

## Conformité à l’énoncé
Toutes les exigences du **Laboratoire de révision** ont été respectées :
- Ajout, suppression et effacement fonctionnels.  
- Compteur dynamique à jour.  
- Désactivation automatique des boutons lorsque la liste est vide.  
- Affichage toujours formaté à deux décimales.  
- Arrondi automatique du prix à deux chiffres après la virgule.

---

## À faire (To-Do)
- [ ] Ajouter une **validation des données** saisies par l’utilisateur :  
  - Vérifier que le champ nom n’est pas vide.  
  - Empêcher les valeurs de prix négatives ou nulles.  
  - Afficher un message d’erreur clair si la saisie est invalide.
- [ ] Ajouter des **icônes et images** à l’interface (PictureBox, logo, etc.).
- [ ] Améliorer l’esthétique avec des couleurs cohérentes et un design plus moderne.

---

## Technologies utilisées
- **Langage :** C# (.NET Framework)
- **Environnement :** Visual Studio 2022
- **Interface :** Windows Forms (`System.Windows.Forms`)
- **Collection utilisée :** `BindingList<Produit>`

---

## Auteur
Projet réalisé par **Dimitar Simeonov**  
Cours **420-3D4-MO – Interface utilisateur**



         _nnnn_                      
        dGGGGMMb     ,"""""""""""""""""""".
       @p~qp~~qMb    | PingWinning Rules! |
       M|@||@) M|   _;....................'
       @,----.JM| -'
      JS^\__/  qKL
     dZP        qKRb
    dZP          qKKb
   fZP            SMMb
   HZM            MMMM
   FqM            MMMM
 __| ".        |\dS"qML
 |    `.       | `' \Zq
_)      \.___.,|     .'
\____   )MMMMMM|   .'
     `-'       `--' 

---
