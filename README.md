# boekingssysteem

Om dit programma correct uit te voeren, dienen zowel de api, het boekingssysteem, als de database tegelijk te draaien.

Om een vakantie te kunnen boeken, moeten gegevens worden ingevoerd die in de database staan. In deze GitHub staan staat een database met testdata, deze dient handmatig in MS SQL Server Managment Studio geimporteerd te worden.

Data toevoegen kan direct in de database of via de api. Let bij het aanmaken van data op een aantal dingen:
* Als je een hotel aanmaakt, maakt dan ook altijd een room aan met dit hotel-id. Een hotel zonder rooms kan niet bestaan.
* Als je een vlucht aanmaakt, geef deze dan altijd een vliegtuid-id mee van een vliegtuig dat bestaat
* Bij het boeken van de heenvlucht, let de applicatie op de aankomsttijd van het vliegtuig. Je vakantie begint namelijk pas zodra het vliegtuig is geland. Als een vliegtuig op de 1e v.d. maand vertrekt en op de 2e aankomt, kun de deze ophalen in het programma door de 2e van de maand in te vullen bij begindatum.
* Bij het boeken van de terugvlucht, is het juist andersom. Je vakantie is al voorbij zodra je in het vliegtuig stapt.
* Ons reisbureau is gevestigt in Emmen. Een vlucht die vertrekt uit Emmen is dus altijd een heenvlucht. Een vlucht die naar Emmen gaat, is altijd een terugvlucht.
* Het is mogelijk om een vlucht aan te maken die vanuit Emmen komt noch erheen gaat, deze wordt echter niet door het programma verwerkt.

Fijne vakantie!
