using BusinessLayer.Abstract;
using ClosedXML.Excel;
using DataAccessLayer.Concrete;
using DataAccessLayer.Migrations;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using TraversalRezervasyonApp.Models;

namespace TraversalRezervasyonApp.Controllers
{
    
    public class ExcelController : Controller
    {
        private readonly IExcelService _excelService;

        public ExcelController(IExcelService excelService)
        {
            _excelService = excelService;
        }

        public IActionResult Index()
        {
           return View();
        }


        public List<DestinationModel> DestinationList() 
        {
            List<DestinationModel> destinationModels = new List<DestinationModel>();
            using (var c = new Context())
            {
                destinationModels = c.Destinations.Select(x => new DestinationModel
                {
                    Capacity = x.Capacity,
                    City = x.City,
                    DayNight = x.DayNight,
                    Price= x.Price,
                }).ToList();
            };
            return destinationModels;
        }

        public IActionResult StaticExcelReport()
        {

            return File(_excelService.ExcelList(DestinationList()), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet","YeniDosya.xlsx");
            //application/vnd.openxmlformats-officedocument.spreadsheetml.sheet


        }
        public IActionResult DestinationExcelReport()
        {
            using (var workBook= new XLWorkbook())
            {
                var worksheet = workBook.Worksheets.Add("Tur Listesi");
                worksheet.Cell(1,1).Value = "Şehir";
                worksheet.Cell(1,2).Value = "Konaklama Süresi";
                worksheet.Cell(1,3).Value = "Fiyat";
                worksheet.Cell(1,4).Value = "Kapasite";

                int rowCaunt = 2;
                foreach (var item in DestinationList())
                {
                    worksheet.Cell(rowCaunt, 1).Value = item.City;
                    worksheet.Cell(rowCaunt, 2).Value = item.DayNight;
                    worksheet.Cell(rowCaunt, 3).Value = item.Price;
                    worksheet.Cell(rowCaunt, 4).Value = item.Capacity;
                    rowCaunt++;
                }

                using(var stream=new MemoryStream())
                {
                    workBook.SaveAs(stream);
                    var content=stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet","YeniListe.xlsx");
                }
            }
                 
        }
    }
}
