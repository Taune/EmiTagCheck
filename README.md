# EmiTagCheck
Software for checking EmiTag before start

03.11.2020
- Har lagt inn mulighet for bruk av dialogvindu for valg av katalog til log-fil.
- Har lagt inn sjekk på at katalog for log-fil eksisterer slik at man unngår programkrasj.
- Lagt inn combobox for valg av kode på ECU slik at kun gyldige koder kan velges.
- Har lagt inn progressbar ved lasting av brikkesjekkfil.

22.10.2020
- Korrigert lagring til brikkesjekkfil med korrekt startnr ved stafett
- Noen mindre kosmetiske endringer

20.10.2020
- Brikkesjekkfil blir opprettet ved lesing av startliste fra LiveRes. Denne blir lagret lokalt på samme katalog som log-fil (vanligvis c:\temp\). Filnavn vil være "LiveResStartlist{dato}.csv".
- Ved stafett så blir startnr fra LiveRes konvertert (nr 160 etappe 3 -> 16003)
- Noen mindre feilrettinger.

13.10.2020
- Har endret rutine med tildeling av ukjent brikkenr. Dersom ukjent brikke blir lest, så blir brikkenr lagt til i feltet for "Manuell brikkesøk". Når man trykker på "Endre brikkenr" så hentes brikkenr fra fletet "Manuell brikkesøk". 

12.10.2020
- Ved søk på brikkenr starter søk ved trykk på enter
- Lagt inn funksjon for søk etter startnr. Bruk startnr-felt og trykk enter
- Alle meldinger som sendes til LiveRes meldingstjeneste blir lagt inn i log-fil
- Dersom man legger inn ugyldig nummer ved startnr- og brikkesøk (feks tekst), så får man en advarsel og søk blir ikke utført
- Lagt inn et valg hvor man kan slå av og på varsellyd ved "Ukjent brikkenr"
- Knapp for lesing av ECU og MTR blinker når lesing er aktiv.

04.10.2020
- Lagt inn funksjon for søk i arrangementer i LiveRes database. Skriv inn løps-id og søk opp arrangement.
- Fikset feil med feil medling i log-bilde. Navn på forrige løper ble listet selv om det var ukjent brikke
- Lagt inn funksjon som sender melding til LiveRes om at brikke er sjekket (https://api.freidig.idrett.no/messageapi.php?method=setecardchecked&comp=10006&dbid=340)
