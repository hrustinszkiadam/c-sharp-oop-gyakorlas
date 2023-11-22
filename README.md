# Banki Ügyfelek és Bankszámlák Kezelése
## Cél
A feladat célja egy banki ügyfelek és bankszámlák kezelését lehetővé tevő C# konzolalkalmazás létrehozása. Az alkalmazás tartalmaz két osztályt: Customer és BankAccount. Az Customer osztályban tároljuk az ügyfelek adatait, míg a BankAccount osztályban a bankszámlákat kezeljük.

## Customer Osztály
### Adattagok
```
string customerName - Az ügyfél neve.
int customerAge - Az ügyfél életkora.
string customerAddress - Az ügyfél lakcíme.
string customerEmail - Az ügyfél e-mail címe.
string customerPhoneNumber - Az ügyfél telefonszáma.
```
### Metódusok
```
void PrintCustomerInfo() - Kiírja az ügyfél adatait a konzolra.
void UpdateCustomerInfo(string newName, int newAge, string newAddress, string newEmail, string newPhoneNumber) - Frissíti az ügyfél adatait az új adatokkal.
void PlaceOrder(string product, int quantity) - Feladja az ügyfél rendelését a megadott termékből és mennyiségből.
void RequestSupport(string supportRequest) - Rögzíti az ügyfél támogatási kérését.
void SendFeedback(string feedback) - Rögzíti az ügyfél visszajelzését.
```
## BankAccount Osztály
### Adattagok
```
string ownerName - A számlatulajdonos neve.
decimal balance - A számla egyenlege.
string accountNumber - A bankszámla számlaszáma.
string accountType - A bankszámla típusa.
DateTime accountOpeningDate - A bankszámla nyitásának dátuma.
bool isAccountActive - A bankszámla állapota (aktív vagy inaktív).
```
### Metódusok
```
void PrintAccountInfo() - Kiírja a bankszámla adatait a konzolra.
void CloseAccount() - Lezárja a bankszámlát.
void TransferFundsTo(BankAccount destinationAccount, decimal amount) - Pénzátutalást végez a jelenlegi számláról a célbankszámlára a megadott összeggel.
void UpdateAccountType(string newAccountType) - Frissíti a bankszámla típusát az új típussal.
```
## Feladatlépések
1. Hozz létre egy Customer osztályt, és definiáld az adattagokat és metódusokat, amelyek a fenti leírásban vannak felsorolva.
2. Hozz létre egy BankAccount osztályt, és definiáld az adattagokat és metódusokat, amelyek a fenti leírásban vannak felsorolva.
3. Készíts egy konzolalkalmazást, amely létrehoz egy Customer példányt és egy BankAccount példányt.
4. Hozz létre néhány példányosítási és műveleti lépést a Customer és BankAccount példányokkal, és teszteld a metódusokat a megfelelő eredményekkel.
5. Készítsd el a szükséges kimeneti üzeneteket, hogy a felhasználó könnyen követhesse az alkalmazás működését.
6. Győződj meg róla, hogy az osztályok és metódusok helyesen működnek, és a kimeneti üzenetek tartalmazzák az elvárt információkat.
7. Teszteld az alkalmazást a különböző műveletek végrehajtásával, és győződj meg róla, hogy az eredmények helyesek és az alkalmazás megfelel a követelményeknek.
