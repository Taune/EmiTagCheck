# EmiTagCheck
Software for checking EmiTag before start

Kjente feil:
-

Fixed:
- Får feil når man lukker programmet med "Avslutt" uten å ha åpnet serialport for lesing (Fixed)
- Feil ved "Avslutt" når tråd ikke er stoppet (Stopp-knapp ikke benyttet) (fixed)
- Får feil ved brikkesøk om brikkesjekkfil ikke er lastet (fixed)


Nye løsninger:
- Vise batteristatus på brikke
- Skrive log fra brikkeleser til ei tekstfil
- Lese o-brikker fra feks MTR
- Lese fra GPRS (Elink/ETS)

Løsning inkludert:
- Legge inn varsellyd ved ukjent brikke (NB! Bruker lydfil c:\temp\ringout.wav)
- Lagt inn funksjon som lagrer løpsinfo til config-fil slik at den husker dette ved oppstart. 
