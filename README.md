# EmiTagCheck
Software for checking EmiTag (use of Emit ECU-reader) and ECard (use of Emit MTR-reader) before start.

07.02.2021
- Korrigert feil ved bruk av knapp for "Send melding" slik at riktig dialogboks kommer opp.
- Ved bruke av "Lukk-x" ved avslutning av program så blir valgte data lagret til config-fil
- Nedtrekssmeny for LiveRes-arrengement er korrigert slik at sist brukte arrangement blir default-verid
- Lagt inn hurtigvalg for å gå direkte til startnummer-felt med funksjonstast "F2".
- Lagt inn hurtigvalg for endre brikke på funksjonstast "F3".

26.01.2021
- Ved endring av brikkenummer så sendes det melding til LiveRes om at startnr/brikke er sjekket.
- Endret litt på design for knapp for å bytte brikkenummer.
- Endret melding for bekreftelse for brikkebytte

19.01.2021
- Korrigert feil ved lagring til config-fil

18.12.2020
- Nedtrekksmeny for LiveRes-arrangement er fikset slik at norske tegn vises.
- Lagt til en funksjon for automatisk opplesning av startnummer og navn. Legg inn norsk tale i Windows (Microsoft Jon) og Windows register må oppdateres for å gjøre denne tilgjengelig i programmet. Kjør fila "Update Microsoft Jon.reg",

08.12.2020
- Lagt in "radiobuttons" for valg av kode på ECU. Kan kun velge mellom kode 70 og 251. Kode i ECU endres automatisk ved valg av kode
- Lagt inn mulighet til å få lydvarsel også ved brikke OK ("Brikke OK"). Mulig å slå av og på dette lydvarselet.

02.12.2020
- Har lagt inn mulighet for å velge arrangement direkte fra LiveRes-database. Alle arrangement listes i nedtrekksmeny.
- Endret melding ved ukjent brikke
- Noen mindre design endringer

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
