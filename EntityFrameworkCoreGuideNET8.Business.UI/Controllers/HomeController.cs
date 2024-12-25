using EntityFrameworkCoreGuideNET8.Business.UI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EntityFrameworkCoreGuideNET8.Business.UI.Controllers
{
    /// <summary>
    /// Controller for handling home-related actions.
    /// </summary>
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserService _userService;

        /// <summary>
        /// Initializes a new instance of the <see cref="HomeController"/> class.
        /// </summary>
        /// <param name="logger">The logger instance.</param>
        /// <param name="userService">The user service instance.</param>
        public HomeController(ILogger<HomeController> logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        /// <summary>
        /// Displays the home page.
        /// </summary>
        /// <returns>The home page view.</returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Displays the privacy page.
        /// </summary>
        /// <returns>The privacy page view.</returns>
        public IActionResult Privacy()
        {
            return View();
        }

        /// <summary>
        /// Retrieves all active users.
        /// </summary>
        /// <returns>A list of active users.</returns>
        [HttpGet]
        public async Task<IActionResult> GetAllActiveUser()
        {
            try
            {
                var user = await _userService.GetAllActiveUsersAsync();
                if (user == null)
                {
                    return NotFound();
                }
                return Ok(user);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while retrieving the user.");
                return StatusCode(500, "An unexpected error occurred.");
            }
        }

        /// <summary>
        /// Displays the error page.
        /// </summary>
        /// <returns>The error page view.</returns>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
