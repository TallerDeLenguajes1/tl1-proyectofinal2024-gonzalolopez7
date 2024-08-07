# MODALIDAD DE PARTIDO:

#### ATAQUES POR VALORACION Y DEFENSA POR PROBABILIDADES.
#### EL PRIMERO QUE LLEGA A 21 PTS GANA.
#### ELECCION ALEATORIA DE TIPO DE ATAQUE Y ELECCION POR PROBABILIDAD DE TIPO DE DEFENSA

## ATAQUE

SE ELIGE EL TIPO DE ATAQUE Y, SI SE SUPERA LA DEFENSA, SE REALIZA UN INTENTO DE CONVERSION DETERMINADO POR UNA FORMULA QUE TIENE EN CUENTA UNA PROBABILIDAD FIJA Y VARIA DEPENDIENDO DE LAS ESTADISTICAS (TIRO Y CREACION) DEL EQUIPO Y DE UN FACTOR SUERTE QUE PUEDE SER POSITIVO O NEGATIVO

### TIPOS:
- BANDEJA	    50%
- DUNK		    30%
- TRIPLE	    20%
- TIRO LIBRE    (SOLO SI HAY FALTA) - (LO REALIZA EL CAPITAN)

#### CONFORMACION BONUS SEGUN ESTADISTICAS:
- BANDEJA:	    30% TIRO - 70% CREACION
- DUNK:		    30% TIRO - 70% CREACION
- TRIPLE:	    75% TIRO - 25% CREACION
- TIRO LIBRE:   100% TIRO CAPITAN

### FORMULAS DE ATAQUE:
EL FACTOR SUERTE HACE VARIAR A LAS FORMULAS DE MANERA NEGATIVA O POSITIVA (+/- 5)

- BANDEJA:      60% + 0.5 * bonusEstadisticas +/- factorSuerte
- DUNK:         40% + 0.5 * bonusEstadisticas +/- factorSuerte
- TRIPLE:       30% + 0.5 * bonusEstadisticas +/- factorSuerte
- TIRO LIBRE:   70% + 0.5 * bonusEstadisticas +/- factorSuerte


## DEFENSA

ANTES DE CALCULAR LA CONVERSION DEL ATAQUE, SE CALCULA UNA PROBABILIDAD DE EXITO DE LA DEFENSA QUE TIENE EN CUENTA UNA PROBABILIDAD FIJA Y VARIA DEPENDIENDO DE LAS ESTADISTICAS (DEFENSA INTERIOR Y DEFENSA PERIMETRO) DEL EQUIPO Y DE UN FACTOR SUERTE QUE PUEDE SER POSITIVO O NEGATIVO

### TIPOS:
- BLOQUEO
- ROBO

### PROBABILIDADES DE TIPO DE DEFENSA DEPENDIENDO EL TIPO DE ATAQUE:
- BANDEJA:
    - BLOQUEO   25%
    - ROBO      15%
- DUNK:
    - BLOQUEO   20%
    - ROBO      10%
- TRIPLES:
    - BLOQUEO   10%
    - ROBO      5%

### FORMULAS DE DEFENSA:
EL FACTOR SUERTE HACE VARIAR A LAS FORMULAS DE MANERA NEGATIVA O POSITIVA (+/- 5)

- BLOQUEO:      porcentajeSegunTipoAtaque + 0.2 * (defensaInterior + defensaPerimetro) +/- factorSuerte
- ROBO:         porcentajeSegunTipoAtaque + 0.2 * defensaPerimetro +/- factorSuerte

### FALTAS:
SI SE REALIZA UN INTENTO DE DEFENSA, HAY UNA PROBABILIDAD DE COMETER UNA FALTA:

#### PROBABILIDAD DE FALTA
- BLOQUEO:      15% - 0.5 (defensaInterior + defensaExterior)
- ROBO:         10% - 0.5 (defensaInterior + defensaExterior)

## REBOTES:
SI UN TRIPLE NO ENTRA SE PONE EN DISPUTA EL REBOTE Y SI EL EQUIPO ATACANTE GANA EL REBOTE, SE REALIZA OTRO ATAQUE CON UNA MENOR PROBABILIDAD DE CONVERSION.

#### PROBABILIDAD DE GANAR EL REBOTE:
- DEFENSA:	70%
- ATAQUE:	30%
