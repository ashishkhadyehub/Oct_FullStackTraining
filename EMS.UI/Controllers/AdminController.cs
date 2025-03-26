using EMS.Entities;
using EMS.Repositories.Interfaces;
using EMS.UI.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EMS.UI.Controllers
{
    public class AdminController : Controller
    {
        private readonly IGenericRepo<Branch> _branchRepo;
        private readonly IGenericRepo<Department> _departmentRepo;

        public AdminController(IGenericRepo<Branch> branchRepo, IGenericRepo<Department> departmentRepo)
        {
            _branchRepo = branchRepo;
            _departmentRepo = departmentRepo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> BranchList()
        {
            var branchList = await _branchRepo.GetAll();

            var vm = new List<BranchViewModel>();

            foreach (var branch in branchList)
            {
                vm.Add(new BranchViewModel
                {
                    Id = branch.Id,
                    BranchName = branch.BranchName,
                    BranchHead = branch.BranchHead,
                    Address = branch.Address
                });
            }

            return View(vm);
        }

        [HttpGet]
        public async Task<IActionResult> CreateBranch()
        {

            return View();
        }

        public async Task<IActionResult> CreateBranch(BranchViewModel vm)
        {
            var branch = new Branch
            {
                Id = vm.Id,
                BranchName = vm.BranchName,
                BranchHead = vm.BranchHead,
                Address = vm.Address
            };

            await _branchRepo.Save(branch);
            TempData["Message"] = "True";
            return RedirectToAction("BranchList");
        }

        [HttpGet]
        public async Task<IActionResult> EditBranch(int id)
        {
            var branch = await _branchRepo.GetById(id);
            var vm = new BranchViewModel
            {
                Id = branch.Id,
                BranchName = branch.BranchName,
                BranchHead = branch.BranchHead,
                Address = branch.Address
            };

            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> EditBranch(BranchViewModel vm)
        {

            var branch = new Branch
            {
                Id = vm.Id,
                BranchName = vm.BranchName,
                BranchHead = vm.BranchHead,
                Address = vm.Address
            };

            await _branchRepo.Edit(branch);

            return RedirectToAction("BranchList");
        }

        public async Task<IActionResult> DeleteBranch(BranchViewModel vm)
        {
            var Branch = new Branch
            {
                Id = vm.Id,
                BranchName = vm.BranchName,
                BranchHead = vm.BranchHead,
                Address = vm.Address
            };
            await _branchRepo.RemoveData(Branch);
            return RedirectToAction("BranchList");
        }

        public async Task<IActionResult> DeptList()
        {
            var departments = await _departmentRepo.GetAll();
            var vm = new List<DepartmentViewModel>();
            foreach (var department in departments)
            {
                vm.Add(new DepartmentViewModel
                {
                    Id = department.Id,
                    Name = department.Name
                });
            }
            return View(vm);
        }

        [HttpGet]
        public async Task<IActionResult> CreateDept()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateDept(DepartmentViewModel vm)
        {
            var dept = new Department
            {
                Id = vm.Id,
                Name = vm.Name,

            };

            await _departmentRepo.Save(dept);
            return RedirectToAction("DeptList");


        }

        [HttpGet]
        public async Task<IActionResult> EditDept(int id)
        {
            var dept = await _departmentRepo.GetById(id);
            var vm = new DepartmentViewModel { Id = dept.Id, Name = dept.Name };
            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> EditDept(DepartmentViewModel vm)
        {
            var dept = new Department
            {
                Id = vm.Id,
                Name = vm.Name,

            };

            await _departmentRepo.Edit(dept);
            return RedirectToAction("DeptList");


        }

        public async Task<IActionResult> DeleteDept(DepartmentViewModel vm)
        {
            var dept = new Department
            {
                Id = vm.Id,
                Name = vm.Name,
            };
            await _departmentRepo.RemoveData(dept);
            return RedirectToAction("DeptList");
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(AdminLoginViewModel vm)
        {
            if (vm.UserName == "admin" && vm.Password == "admin")
            {
                HttpContext.Session.SetString("Admin", "True");
                return RedirectToAction("BranchList");
            }
            else
            {
                ViewData["Message"] = "Invalid Login";
                return View();
            }

        }


    }
}
