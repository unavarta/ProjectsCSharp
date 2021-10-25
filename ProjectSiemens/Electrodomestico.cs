using System;

public class Electrodomestico

{
    private int _precioElectro, _pesoElectro;
    private char _colorElectro, _consumoElectro;

    //constructor por parametro
    public Electrodomestico(int _precioElectro, int _pesoElectro, char _colorElectro, char _consumoElectro)
    {
        this._precioElectro = _precioElectro;
        this._pesoElectro = _pesoElectro;
        AsignarColor(" ");
        AsignarConsumo(" ");
    }

    //POR DEFECTO
    public Electrodomestico()
    {
        this._precioElectro = 100;
        this._pesoElectro = 5;
        this._colorElectro = "BLANCO";
        this._consumoElectro = "F";
    }

    //constructor por parametro PRECIO Y PESO
    public Electrodomestico(int _precioElectro, int _pesoElectro)
    {
        this._precioElectro = _precioElectro;
        this._pesoElectro = _pesoElectro;
        this._consumoElectro = "F";
        this._colorElectro = "BLANCO";
    }

    public int precioElectro { get => _precioElectro; set => value; }
    public int pesoElectro { get => _pesoElectro; set => value; }
    public String consumoElectro { get => _consumoElectro; set => value; }
    public String colorElectro { get => _colorElectro; set => value; }



    public void AsignarConsumo(char _consumoElectro)
    {
        _consumoElectro.ToUpper();

        if (_consumoElectro = "A" || _consumoElectro = "B" || _consumoElectro = "C" || _consumoElectro = "D" || _consumoElectro = "E" || _consumoElectro = "F")
        {
            this._consumoElectro = _consumoElectro;
        }
        else
        {
            this._consumoElectro = "F";
        }
    }

    public void AsignarColor(String _colorElectro)
    {
        _colorElectro.ToUpper();
        if (_colorElectro = "BLANCO" || _colorElectro = "GRIS" || _colorElectro = "ROJO" || _colorElectro = "NEGRO" || _colorElectro = "AZUL")
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

        switch (_consumoElectro)
        {
            case 'A':
                _precioElectro += 100;
                break;

            case 'B':
                _precioElectro += 80;
                break;

            case 'C':
                _precioElectro += 60;
                break;

            case 'D':
                _precioElectro += 50;
                break;

            case 'E':
                _precioElectro += 30;
                break;

            case 'F':
                _precioElectro += 10;
                break;
        }

        if (_pesoElectro > 0 && _pesoElectro <= 19)
        {
            _precioElectro += 10;
        }
        else if (_pesoElectro > 20 && _pesoElectro <= 49)
        {
            _precioElectro += 50;
        }
        else if (_pesoElectro > 50 && _pesoElectro <= 79)
        {
            _precioElectro += 80;
        }
        else if(_precioElectro > 80)
        {
            _precioElectro += 100;
        }

    }
}
