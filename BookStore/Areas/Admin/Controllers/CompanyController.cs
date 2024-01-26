using Book.DataAccess.Repository.Interface;
using Book.Models;
using Book.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BulkyBookWeb.Controllers
{ 
[Area("Admin")]
[Authorize(Roles = SD.Role_Admin)]
public class CompanyController : Controller
{
	private readonly IUnitOfWork _unitOfWork;

	public CompanyController(IUnitOfWork unitOfWork)
	{
		_unitOfWork = unitOfWork;
	}

	public IActionResult Index()
	{
		List<Company> companies = _unitOfWork.Company.GetAll().ToList();

		return View(companies);
	}

	//GET
	public IActionResult Upsert(int? id)
	{
		Company company = new();

		if (id == null || id == 0)
		{
			return View(company);
		}
		else
		{
			company = _unitOfWork.Company.Get(u => u.Id == id);
			return View(company);
		}
	}

	//POST
	[HttpPost]
	[ValidateAntiForgeryToken]
	public IActionResult Upsert(Company obj)
	{

		if (ModelState.IsValid)
		{

			if (obj.Id == 0)
			{
				_unitOfWork.Company.Add(obj);
				TempData["success"] = "Company created successfully";
			}
			else
			{
				_unitOfWork.Company.Update(obj);
				TempData["success"] = "Company updated successfully";
			}
			_unitOfWork.Save();

			return RedirectToAction("Index");
		}
		return View(obj);
	}



	#region API CALLS
	[HttpGet]
	public IActionResult GetAll()
	{
		List<Company> company = _unitOfWork.Company.GetAll().ToList();
		return Json(new { data = company });
	}

	//POST
	[HttpDelete]
	public IActionResult Delete(int? id)
	{
		var obj = _unitOfWork.Company.Get(u => u.Id == id);
		if (obj == null)
		{
			return Json(new { success = false, message = "Error while deleting" });
		}

		_unitOfWork.Company.Remove(obj);
		_unitOfWork.Save();
		return Json(new { success = true, message = "Delete Successful" });

	}
	#endregion
}
}
