using System;

public class Electrodomestico

{
    public double _precioElectro, _pesoElectro;
    public String _colorElectro;
    public char _consumoElectro;

    public double precioElectro { get => _precioElectro; }
    public double pesoElectro { get => _pesoElectro; }
    public char consumoElectro { get => _consumoElectro; }
    public String colorElectro { get => _colorElectro; }


    //constructor por parametro
    public Electrodomestico(double _precioElectro, double _pesoElectro, String _colorElectro, char _consumoElectro)
    {
        this._precioElectro = _precioElectro;
        this._pesoElectro = _pesoElectro;
        AsignarColor(" ");
        AsignarConsumo(' ');
    }

    //POR DEFECTO
    public Electrodomestico()
    {
        this._precioElectro = 100;
        this._pesoElectro = 5;
        this._colorElectro = "BLANCO";
        this._consumoElectro = 'F';
    }

    //constructor por parametro PRECIO Y PESO
    public Electrodomestico(double _precioElectro, double _pesoElectro)
    {
        this._precioElectro = _precioElectro;
        this._pesoElectro = _pesoElectro;
        this._consumoElectro = 'F';
        this._colorElectro = "BLANCO";
    }

    public void AsignarConsumo(char _consumoElectro)
    {


        if (_consumoElectro == 'A' || _consumoElectro == 'B' || _consumoElectro == 'C' || _consumoElectro == 'D' || _consumoElectro == 'E' || _consumoElectro == 'F')
        {
            this._consumoElectro = _consumoElectro;
        }
        else
        {
            this._consumoElectro = 'F';
        }
    }

    public void AsignarColor(String _colorElectro)
    {
        if (_colorElectro == "BLANCO" || _colorElectro == "GRIS" || _colorElectro == "ROJO" || _colorElectro == "NEGRO" || _colorElectro == "AZUL")
        {
            this._colorElectro = _colorElectro;
        }
        else
        {
            _colorElectro = "BLANCO";
        }
    }

    public void PrecioFinal()
    {

        double precioParcial = 0;

        switch (_consumoElectro)
        {
            case 'A':
                precioParcial += 100;
                break;

            case 'B':
                precioParcial += 80;
                break;

            case 'C':
                precioParcial += 60;
                break;

            case 'D':
                precioParcial += 50;
                break;

            case 'E':
                precioParcial += 30;
                break;

            case 'F':
                precioParcial += 10;
                break;
        }

        if (_pesoElectro > 0 && _pesoElectro <= 19)
        {
            precioParcial += 10;
        }
        else if (_pesoElectro > 20 && _pesoElectro <= 49)
        {
            precioParcial += 50;
        }
        else if (_pesoElectro > 50 && _pesoElectro <= 79)
        {
            precioParcial += 80;
        }
        else if (_precioElectro > 80)
        {
            precioParcial += 100;
        }

        this._precioElectro += precioParcial;


    }
}
