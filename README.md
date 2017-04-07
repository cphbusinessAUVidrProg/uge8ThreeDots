# uge8ThreeDots

Dette er det program som vi snakkede om torsdag den 6 april.

Der indgår en del elementer som til sammen giver en løsning.

- Der er en model der *ikke* indeholder noget brugergrænseflade, 
men som blot holder styr på hvilke prikker der er, samt hvilken af dem der er 
det element der i øjeblikket er det udvalgte.

- Der bruges **events** til at kommunikere mellem model og brugergrænseflade.
- Der bruges events til at kommunikere fra usercontrol til formen.
- Der bruges properties med ikke trivielle getter setter (specielt at setter sender events)
- Læg mærke til at det at sende et event ligner et metodekald

