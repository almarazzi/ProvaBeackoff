# Progetto Beckhoff e C# con TwinCAT.Ads

## Descrizione

Questo progetto integra un **PLC Beckhoff** con un'applicazione C# utilizzando la libreria **TwinCAT.Ads** per connettersi e interagire con il PLC. Il progetto è stato realizzato per testare la logica di incremento di una variabile su pressione di un bottone e verificare la comunicazione tra il PLC e un'applicazione C#.

### Funzionalità

- **Logica Beckhoff**: Incrementa la variabile `c` ogni volta che il bottone è premuto.
- **Applicazione C#**: Utilizza **TwinCAT.Ads** per connettersi al PLC e interagire con le variabili.

## Architettura

1. **Beckhoff PLC Logic (Structured Text)**:
   - La logica nel PLC incrementa la variabile `c` ogni volta che il bottone è premuto.
   
   ```structured-text
   IF (bottone = true) THEN
       c := c + 1;
   END_IF
   ```
   
   
