import java.time.LocalDate;
import java.time.Period;
import java.time.format.DateTimeFormatter;
public class Persona {
    String nombre;
    LocalDate fechadenac;
    private LocalDate ahora;
    private Period periodo;
    private DateTimeFormatter fmt;
    public int Edad(){
        ahora=LocalDate.now();
        periodo=Period.between(fechadenac,ahora);
        return periodo.getYears();
    }


    public Persona(String nombre, String fechaNacimiento){
        fmt = DateTimeFormatter.ofPattern("dd/MM/yyyy");
        this.nombre=nombre;
        this.fechadenac = LocalDate.parse(fechaNacimiento,fmt);
    }
}
