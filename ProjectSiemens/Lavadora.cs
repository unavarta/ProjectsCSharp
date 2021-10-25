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
    public Lavadora(int _precioElectro, int _pesoElectro, char _colorElectro, char _consumoElectro, int _cargaLava)
        : base(_precioElectro, pesoElectro, _colorElectro, _consumoElectro)
    {
        this._cargaLava = _cargaLava;
    }

    //constructor por parametro precio y peso
    public Lavadora(int _precioElectro, int _pesoElectro) : base()
    {
        _cargaLava = 5;

    }

    //get 'n set
    public int CargaLava { get => _cargaLava; set => value; }

    public void precioFinal()
    {

        if (_cargaLava > 30)
        {
            _precioElectro += 60;
        }
        else
        {
            _precioElectro += 0;
        }

    }


}
