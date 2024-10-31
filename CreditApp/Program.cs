using System;
using Gtk;

public class CreditForm : Window
{
    Entry[] entries;
    Label resultLabel;

    public CreditForm() : base("Formulario de Crédito")
    {
        
        SetDefaultSize(400, 500);
        SetPosition(WindowPosition.Center);
        
        VBox mainVBox = new VBox(false, 10);
        
        Table table = new Table(20, 2, false);
        
        string[] labelsText = {
            "Estado de la cuenta corriente", "Duración (en meses)", "Historial de crédito",
            "Propósito", "Monto del crédito", "Cuenta de ahorro/bono", "Empleo actual desde",
            "Tasa de pago en cuotas", "Estado personal y género", "Otros deudores/garantes",
            "Residencia actual desde", "Propiedad", "Antigüedad en años",
            "Otros planes de cuotas", "Vivienda", "Número de créditos existentes",
            "Empleo", "Número de dependientes", "Teléfono", "Trabajador extranjero"
        };

        entries = new Entry[20];

        for (int i = 0; i < labelsText.Length; i++)
        {
            Label label = new Label(labelsText[i]);
            entries[i] = new Entry();
            table.Attach(label, 0, 1, (uint)i, (uint)(i + 1));
            table.Attach(entries[i], 1, 2, (uint)i, (uint)(i + 1));
        }

        mainVBox.PackStart(table, true, true, 0);

        Button consultButton = new Button("Consultar");
        consultButton.Clicked += OnConsultButtonClicked;
        mainVBox.PackStart(consultButton, false, false, 0);

        resultLabel = new Label("Resultado:");
        mainVBox.PackStart(resultLabel, false, false, 0);

        Add(mainVBox);
        ShowAll();
    }

    private void OnConsultButtonClicked(object sender, EventArgs e)
    {
        // Aquí puedes agregar la lógica de evaluación del riesgo
        resultLabel.Text = "Bajo Riesgo";
    }

    public static void Main()
    {
        Application.Init();
        new CreditForm();
        Application.Run();
    }
}
