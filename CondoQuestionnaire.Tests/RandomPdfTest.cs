
using System.Linq;
using IronPdf;
using NUnit.Framework;

namespace CondoQuestionnaire.Tests;

public class RandomPdfTest
{
    [Test]
    public void CheckFields()
    {
        var pdfDocument = PdfDocument.FromFile(@"Resources/Form 1076 - Condo Project Questionnaire updated 1221.pdf");

        var form = pdfDocument.Form;

        var fieds = form.Fields.Select(f => f.Name);

        var test = "";
    }
}