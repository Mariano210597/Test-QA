using Microsoft.Playwright.NUnit;
using Microsoft.Playwright;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class ahora : PageTest
{
    [Test, Order(1)]
    public async Task pesca()
    { 
        await Page.GotoAsync("https://autogestion-beta.dpec.com.ar/turnos/registrarturno");

        await Page.GetByPlaceholder("E-mail").FillAsync("mariano210597@gmail.com");

        await Page.GetByPlaceholder("Contraseña").FillAsync("Pascualin2105");

        await Page.GetByRole(AriaRole.Button, new() { Name = "INGRESAR", Exact = true }).ClickAsync();

        await Page.WaitForLoadStateAsync(LoadState.NetworkIdle);

        await Page.GetByRole(AriaRole.Link, new() { Name = " Inicio" }).ClickAsync();

        
        await Page.GetByRole(AriaRole.Link, new() { Name = " Mis medidores" }).ClickAsync();

        await Page.GetByRole(AriaRole.Button, new() { Name = " Asociar un nuevo medidor" }).ClickAsync();

        await Page.GetByLabel("Nro de usuario/cliente").ClickAsync();

        await Page.GetByLabel("Nro de usuario/cliente").FillAsync("30129963");

        await Page.GetByLabel("Nro de usuario/cliente").PressAsync("Tab");

        await Page.GetByLabel("Nro de medidor").ClickAsync();

        await Page.GetByLabel("Nro de medidor").FillAsync("3704229");

        await Page.GetByRole(AriaRole.Button, new() { Name = " Siguiente" }).ClickAsync();

        await Page.GetByRole(AriaRole.Button, new() { Name = "Aceptar" }).ClickAsync();
        
        await Page.GetByRole(AriaRole.Link, new() { Name = " Inicio" }).ClickAsync();    

        await Page.WaitForTimeoutAsync(3000);
        await Page.GetByRole(AriaRole.Link, new() { Name = " Mis medidores" }).ClickAsync();

        await Page.GetByRole(AriaRole.Cell, new() { Name = "GARCIA GABRIEL ALEJANDRO  Ver detalles  Editar datos de referencia" }).GetByRole(AriaRole.Button, new() { Name = " Ver detalles" }).ClickAsync();

        await Page.WaitForLoadStateAsync(LoadState.DOMContentLoaded);

        await Page.WaitForTimeoutAsync(2000);


        await Page.GetByRole(AriaRole.Link, new() { Name = "Factura actual" }).ClickAsync();

        await Page.WaitForLoadStateAsync(LoadState.NetworkIdle);


        await Page.GetByRole(AriaRole.Button, new() { Name = "Pagar" }).Nth(1).ClickAsync();

        await Page.GetByRole(AriaRole.Row, new() { Name = "10/03/2023 0071B13460636A Factura ISU $ 10354,59 $ 10354,59  Descargar  Agregar al Carrito" }).GetByRole(AriaRole.Button, new() { Name = " Agregar al Carrito" }).ClickAsync();

        await Page.GetByRole(AriaRole.Button, new() { Name = "Pagar" }).ClickAsync();

        await Page.GetByRole(AriaRole.Button, new() { Name = "Wee! Pasarela de pago Wee !" }).ClickAsync();

        await Page.GetByRole(AriaRole.Button, new() { Name = "Tarjeta de crédito ver costos" }).ClickAsync();

        await Page.GetByRole(AriaRole.Button, new() { Name = "Aceptar" }).ClickAsync();

        await Page.GetByRole(AriaRole.Textbox, new() { Name = "Titular (como aparece en la Tarjeta)" }).ClickAsync();

        await Page.GetByRole(AriaRole.Textbox, new() { Name = "Titular (como aparece en la Tarjeta)" }).FillAsync("mariano vivaldo");

        await Page.GetByRole(AriaRole.Spinbutton, new() { Name = "Número de la Tarjeta" }).ClickAsync();

        await Page.GetByRole(AriaRole.Spinbutton, new() { Name = "Número de la Tarjeta" }).FillAsync("4507990000004905");

        await Page.GetByRole(AriaRole.Textbox, new() { Name = "Codigo de seguridad" }).ClickAsync();

        await Page.GetByRole(AriaRole.Textbox, new() { Name = "Codigo de seguridad" }).FillAsync("123");

        await Page.GetByRole(AriaRole.Button, new() { Name = "Mes de Vencimiento" }).ClickAsync();

        await Page.GetByRole(AriaRole.Option, new() { Name = "7" }).GetByText("7").ClickAsync();

        await Page.GetByRole(AriaRole.Button, new() { Name = "Año de Vencimiento" }).ClickAsync();

        await Page.GetByText("2030").ClickAsync();

        await Page.GetByRole(AriaRole.Button, new() { Name = "Cuotas" }).ClickAsync();

        await Page.GetByText("1 - $ 10.354,59").ClickAsync();

        await Page.GetByRole(AriaRole.Spinbutton, new() { Name = "Número de Identificación" }).ClickAsync();

        await Page.GetByRole(AriaRole.Spinbutton, new() { Name = "Número de Identificación" }).FillAsync("40420421");

        await Page.GetByRole(AriaRole.Button, new() { Name = "Pagar" }).ClickAsync();

        await Page.GetByRole(AriaRole.Button, new() { Name = "Aceptar" }).ClickAsync();

        await Page.GetByRole(AriaRole.Link, new() { Name = " Ir a mis medidores" }).ClickAsync();
        
        await Page.GetByRole(AriaRole.Link, new() { Name = " Inicio" }).ClickAsync();

        await Page.GetByRole(AriaRole.Link, new() { Name = " Reclamos técnicos" }).ClickAsync();

        await Page.WaitForLoadStateAsync(LoadState.NetworkIdle);

        await Page.GetByRole(AriaRole.Button, new() { Name = " Crear Reclamo" }).ClickAsync();

        await Page.WaitForTimeoutAsync(2000);

        await Page.Locator(".form-select.shadow").First.SelectOptionAsync(values:"0");
        await Page.Locator(".form-select.shadow").SelectOptionAsync(values:"3704229");
        await Page.WaitForTimeoutAsync(2000);
       
        await Page.Locator(".form-select.shadow").Nth(1).SelectOptionAsync(values:"2");
        await Page.GetByRole(AriaRole.Button, new() { Name = "Crear Reclamo Baja tensión" }).ClickAsync();
        await Page.WaitForLoadStateAsync(LoadState.NetworkIdle);
        await Page.GetByRole(AriaRole.Button, new() { Name = "Ver Reclamos Técnicos" }).ClickAsync();
        await Page.GetByRole(AriaRole.Combobox).SelectOptionAsync(new[] { "3704229" });
        await Page.WaitForLoadStateAsync(LoadState.NetworkIdle);
        await Page.GetByRole(AriaRole.Button, new() { Name = "Cerrar Reclamo " }).ClickAsync();
        await Page.GetByRole(AriaRole.Link, new() { Name = " Inicio" }).ClickAsync();  
        await Page.GetByRole(AriaRole.Link, new() { Name = " Reclamos comerciales" }).ClickAsync();

        await Page.GetByRole(AriaRole.Button, new() { Name = " Crear Reclamo" }).ClickAsync();

        await Page.WaitForTimeoutAsync(2000);

        await Page.Locator(".form-select.shadow").SelectOptionAsync(values:"0");


        await Page.Locator(".form-select.shadow").SelectOptionAsync(values:"3704229");
        
        await Page.WaitForTimeoutAsync(2000);

        await Page.Locator(".form-select.shadow").Nth(1).SelectOptionAsync(values:"10001");

        await Page.GetByRole(AriaRole.Button, new() { Name = "Crear Reclamo" }).ClickAsync();

        await Page.WaitForLoadStateAsync(LoadState.NetworkIdle);

        await Page.GetByRole(AriaRole.Button, new() { Name = "Ver Reclamos Comerciales" }).ClickAsync();

        await Page.WaitForLoadStateAsync(LoadState.NetworkIdle);

        await Page.WaitForTimeoutAsync(2000);

        await Page.Locator(".form-select.shadow").SelectOptionAsync(values:"3704229");

        await Page.GetByRole(AriaRole.Link, new() { Name = " Inicio" }).ClickAsync();  


        await Page.GetByRole(AriaRole.Link, new() { Name = " Mis medidores" }).ClickAsync();
        await Page.GetByRole(AriaRole.Cell, new() { Name = "GARCIA GABRIEL ALEJANDRO  Ver detalles  Editar datos de referencia" }).GetByRole(AriaRole.Button, new() { Name = " Ver detalles" }).ClickAsync();
        await Page.WaitForLoadStateAsync(LoadState.NetworkIdle);
        await Page.WaitForTimeoutAsync(2000);

        await Page.GetByRole(AriaRole.Button, new() { Name = "" }).ClickAsync();
        await Page.GetByRole(AriaRole.Link, new() { Name = " Desasociar medidor" }).ClickAsync();
        await Page.GetByRole(AriaRole.Button, new() { Name = "Desasociar" }).ClickAsync();

        await Page.GetByRole(AriaRole.Button, new() { Name = "Volver a mis medidores" }).ClickAsync();

        
        await Page.PauseAsync();

        
        }

}

        


