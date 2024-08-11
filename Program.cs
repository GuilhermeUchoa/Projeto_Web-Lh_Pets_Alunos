using Projeto_Web_Lh_Pets_versão_1;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Projeto web - LH Pets versão 1");

app.UseStaticFiles(); //Habilitando static files

app.MapGet("/index", (HttpContext contexto)=>{
    contexto.Response.Redirect("index.html",false);
   
});

Banco dba = new Banco();
app.MapGet("/listaClientes", (HttpContext contexto)=>{

    contexto.Response.WriteAsync(dba.GetListaString());
});

app.Run();
