# EmiTagCheck
Software for checking EmiTag (use of Emit ECU-reader) and ECard (use of Emit MTR-reader) before start.
If used with Pål Kittilsen LiveRes (https://github.com/palkitt/liveresults), eTiming can be updated automatically. 

![image](https://user-images.githubusercontent.com/59508210/122427162-2bfadb00-cf91-11eb-9517-702f5acb6b13.png)

For PC med Windows 7 eller 8:
- Dersom Brikkesjekk-program skal benyttes på en PC med Windows 7 eller 8, så må sertifikat for TLS 1.2 aktiveres. Dette må være aktivert for at kommunikasjon med LivRes-server skal fungere. Fremgangsmåte for aktivering av TLS 1.2 ligger her: https://hosting.ca/how-to-enable-tls-1-2-on-windows-7/

04.04.2023
- Lagt inn sjekk om internettforbindelse før lesing av LiveRes startliste for å unngå at program henger seg.
- Knapp for lesing av Etiming brikkesjekkfil satt inaktiv når LiveRes-startliste er aktiv.
- Dersom PC mangler internettforbindelse ved sending av meldinger (gjelder alle typer meldinger), så lagres meldinger i minnet til programmet. Når internettforbindelse er i orden igjen, så blir meldinger sendt på nytt. Sjekker for uleste meldinger en gang hvert minutt. Meldingene blir slettet når programmet lukkes.

08.10.2022
- Har endret vindu for startliste slik at det ikke er mulig å gjøre endringer på feltene der ved en feiltakelse
- Lagt til en knapp med link til LiveRes meldingsserver slik at man kan følge med på status til endringer.
- Har endret funksjon på ny lesing av startliste fra LiveRes. Dersom det ikke er gjort endringer fra Etiming og startliste i LiveRes er uendret, så blir ikke startliste lest på nytt.
- Lagt til et felt hvor man kan legge inn hvor ofte startliste skal leses fra LiveRes. Ved mange deltakere så bør ikke dette skje for ofte.

13.06.2022
- Starttid for løper vises sammen med annen løperinfo
- Det er nå mulig å klikke på alle felt i startliste for å få opp startnummer
- Standard verdi for oppdatering av startliste fra LiveRes er satt til 5 min. Denne kan nå endres i config-fil (Brikkesjekk.exe.Config). Der kan man legge inn antall ønskede minutter i variabel "liveres_interval". Ved mange deltakere (mer enn 500 stk), så kan det være lurt å sjekke hvor lang tid en opplastning tar. Dette er avhengig av nettilgang.

27.05.2022
- Endret link i config-fil til ny LiveRes-server (https://api.liveres.live/)
- Ved bruke av ECU kan intern kode settes til 70. Dersom ECU skal benyttes til avlesning av brikker i Etiming eller Brikkesys, så må kode være 250. Kode blir derfor nå automatisk satt tilbake til kode 250.

26.12.2021
- Layout på skjermbilder endret.

17.10.2021
- Ved valg av løp fra LiveRes så er nå dato inkludert i tillegg til løpsnavn.
- Ved lesing av brikke så vises det et symbol om det er en EmiTag eller en Emit o-løper brikke

26.08.2021
- Ved import av stafett fra LiveRes så blir "-" foran startnr fjernet.
- Ved endring av brikke og bruk av LiveRes så er kall til LiveRes endret slik at brikke blir satt til "sjekket" samtidig med brikkeendring.

17.06.2021
- Fikset feil ved trykk på header i datagridview
- Fikset api-kall for at brikke er sjekket ved tildeling av ny brikke
- 
16.06.2021
- Muligheter ved søk i løperbase med startnummer. Skriv inn nummer i startnummerfelt og trykk enter.
- Ved å trykke på startnummer i datagrid så kommer startnummer og løperinfo opp. Dette er nyttig ved tildeling av ukjent brikke til løper som er blitt søkt opp med navn.

13.06.2021
- Lagt inn mulighet for søk etter navn. Skriv inn navn i søkefelt under datagridview.
- Ved å skrive inn et startnummer og trykke "enter" så søkes det etter aktuell løper.
- Endret datagridview fra "unbounded" til "bounded". Dette har medført en omstrukturering av kolonnenavn i forhold til tidligere.

27.03.2021
- Diverse endringer på layout
- Grønn tekst ved Brikke OK og rød tekst ved Ukjent Brikke
- Lagt inn blinkende led diode for aktive ECU/MTR

29.02.2021
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
