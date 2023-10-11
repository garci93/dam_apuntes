using HerenciaAcceso;

CuentaBancaria cb1 = new CuentaBancaria("Pepe",454);
CuentaBancaria cb2 = new CuentaBancaria("Marina",113.05);
CuentaEmpresarial ce1 = new CuentaEmpresarial("Manolo",1326.28);
CuentaEmpresarial ce2 = new CuentaEmpresarial("Luisa",4063.50);

ce1.RealizarTransferencia(cb1, 35);
Console.WriteLine(cb1.MostrarSaldo());
Console.WriteLine(ce1.MostrarSaldo());

ce2.RealizarTransferencia(cb2, 175.1);
Console.WriteLine(cb2.MostrarSaldo());
Console.WriteLine(ce2.MostrarSaldo());

cb1.Depositar(1);
Console.WriteLine(cb1.MostrarSaldo());
cb1.Retirar(1);
Console.WriteLine(cb1.MostrarSaldo());

cb2.Depositar(1.5);
Console.WriteLine(cb2.MostrarSaldo());
cb2.Retirar(1.5);
Console.WriteLine(cb2.MostrarSaldo());