using System;

public class Lavadora : Electrodomestico
{
    private int _cargaLava;


    //constructor por defecto
    public Lavadora() : base()
    {
        _cargaLava = 5;
    }

    //constructor parametro
    public Lavadora(double _precioElectro, double _pesoElectro, String _colorElectro, char _consumoElectro, int _cargaLava)
        : base(_precioElectro, _pesoElectro, _colorElectro, _consumoElectro)
    {
        this._cargaLava = _cargaLava;
    }

    //constructor por parametro precio y peso
    public Lavadora(double _precioElectro, double _pesoElectro) : base()
    {
        _cargaLava = 5;

    }

    //get 'n set
    public int CargaLava { get => _cargaLava;  }

    public void precioFinal()
    {
        double precio = 0;

        if (_cargaLava > 30)
        {
            precio += 60;
        }
        else
        {
            precio += 0;
        }

        this._precioElectro += precio;

    }


}
