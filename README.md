# Gestionarea produselor dintr-un magazin

## Introducere
Proiectul reprezintă un sistem simplu de gestionare a produselor dintr-un magazin. Acesta include funcționalități pentru adăugarea, ștergerea și afișarea produselor, precum și un mecanism de coș de cumpărături pentru clienți. Produsele sunt de două tipuri: perisabile (cu dată de expirare și temperatură de stocare) și neperisabile (cu observații specifice). Totodată, proiectul ilustrează concepte OOP precum moștenirea, abstractizarea și gestionarea listelor, oferind o bază pentru un sistem de gestionare a magazinelor.

## Detalii Despre Implementare

Proiectul este implementat în C# și constă din mai multe clase care facilitează interacțiunea dintre un magazin, produse și clienți.
Componentele principale sunt:
1. **Clase de bază**:
- *Produs*: Clasă abstractă care definește proprietățile de bază ale unui produs (ID, nume, preț) și o metodă abstractă *Descriere()*
- *ProdusPerisabil* și *ProdusNeperisabil*: Clase derivate din *Produs* care adaugă proprietăți specifice (dată de expirare, temperatură de stocare pentru cele perisabile; observații pentru cele neperisabile) și implementează metoda *Descriere()*

2. **Gestionarea magazinului**
*Magazin*: Gestionează un stoc de produse prin metode pentru adăugare (*AdaugaProdus*), eliminare (*StergeProdus*) și afișare (*AfiseazaProduse*). Produsele sunt stocate într-o listă.

3. **Funcționalități pentru clienți**
*Client*: Permite clienților să adauge produse în coș (*AdaugaProduse*), să le elimine (*StergeProdus*) și să efectueze o plată (*Plata*). Coșul de cumpărături este gestionat ca o listă de produse.

4. **Interactiunea componentelor**
- La adăugarea unui produs în coș, acesta este eliminat din stocul magazinului
- La eliminarea unui produs din coș, acesta este returnat în stocul magazinului
- Plata calculează suma totală a produselor din coș și o returnează, după care golește coșul

5. **Execuția programului**
În *Program.cs*, se creează un magazin, se adaugă produse (perisabile și neperisabile), se afișează stocul, se simulează acțiuni ale unui client (adăugare în coș, plată), și se afișează stocul actualizat.
  
