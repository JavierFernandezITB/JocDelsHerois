# Tests
## bool IsInRange(int value, int min, int max)
#### Clases de equivalencia
- Input
  - Input (INT)
  - Min (INT)
  - Max (INT)
- Output
  - BOOLEAN 

### Casos de preuba
| Nº Prueba | Args                               | Expected       |Devuelve |
|-----------|------------------------------------|----------------|---------|
| 1         | 5, 0, 10                           | TRUE           | TRUE    |

## int GenRandomNumber(int low, int high)
#### Clases de equivalencia
- Input
  - low (INT)
  - high (INT)
- Output
  - INT 

### Casos de preuba
| Nº Prueba | Args                               | Expected       | Devuelve |
|-----------|------------------------------------|----------------|----------|
| 1         | 0, 10                              | TRUE           | TRUE     |

## bool CheckValidNames(string[] nameList)
#### Clases de equivalencia
- Input
  - nameList (STRING ARRAY)
- Output
  - BOOLEAN 

### Casos de preuba
| Nº Prueba | Args                               | Expected       | Devuelve |
|-----------|------------------------------------|----------------|----------|
| 1         | { "pa", "ta", "ta", "das" }        | TRUE           | TRUE     |

## bool PrintColored(string msg, ConsoleColor color)
#### Clases de equivalencia
- Input
  - msg (STRING)
  - color (ConsoleColor)
- Output
  - BOOLEAN 

### Casos de preuba
| Nº Prueba | Args                               | Expected       | Devuelve |
|-----------|------------------------------------|----------------|----------|
| 1         | "ABDCD", ConsoleColor.Red          | TRUE           | TRUE     |

## bool FindInArray(int[] arr, int query)
#### Clases de equivalencia
- Input
  - arr (INT ARRAY)
  - query (INT)
- Output
  - BOOLEAN 

### Casos de preuba
| Nº Prueba | Args                               | Expected       | Devuelve |
|-----------|------------------------------------|----------------|----------|
| 1         | { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 5   | TRUE           | TRUE     |

## void SetStat(ref int heroStat, int newHealth)
#### Clases de equivalencia
- Input
  - stat (INT)
  - newstat (INT)
- Output

### Casos de preuba
| Nº Prueba | Args                               | Expected       | Devuelve |
|-----------|------------------------------------|----------------|----------|
| 1         | 0, 5                               | -              | -        |

## bool IsDead(int[][] characterStats, int number)
#### Clases de equivalencia
- Input
  - characterStats (int[][])
  - number (INT)
- Output
  - BOOLEAN

### Casos de preuba
| Nº Prueba | Args                               | Expected       | Devuelve |
|-----------|------------------------------------|----------------|----------|
| 1         | { health }                         | TRUE           | TRUE     |

## int CalcDamage(int[][] characterStats, int targetNum, int damage)
#### Clases de equivalencia
- Input
  - characterStats (int[][])
  - targetNum (INT)
  - damage (INT)
- Output
  - INTEGER

### Casos de preuba
| Nº Prueba | Args                               | Expected       | Devuelve |
|-----------|------------------------------------|----------------|----------|
| 1         | { character }, 0, 100              | 50             | 50       |

## bool IsCrit()
#### Clases de equivalencia
- Input
  
- Output
  - BOOLEAN

### Casos de preuba
| Nº Prueba | Args                               | Expected       | Devuelve |
|-----------|------------------------------------|----------------|----------|
| 1         |                                    | TRUE           | TRUE     |

## bool IsMissed()
#### Clases de equivalencia
- Input
  
- Output
  - BOOLEAN

### Casos de preuba
| Nº Prueba | Args                               | Expected       | Devuelve |
|-----------|------------------------------------|----------------|----------|
| 1         |                                    | TRUE           | TRUE     |
