# EmiTagCheck
Software for checking EmiTag before start

Kjente feil:
- Får feil når man lukker programmet med "Avslutt" uten å ha åpnet serialport for lesing
- Får feil ved brikkesøk om brikkesjekkfil ikke er lastet
- Feil ved "Avslutt" når tråd ikke er stoppet (Stopp-knapp ikke benyttet)

Nye løsninger:
- Vise batteristatus på brikke
- Legge inn varsellyd ved ukjent brikke
- Skrive log fra brikkeleser til ei tekstfil
- Lese o-brikker fra feks MTR
- Lese fra GPRS (Elink/ETS)
