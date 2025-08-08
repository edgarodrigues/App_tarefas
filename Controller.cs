namespace app_tarefas.Controllers
{

    [Authorize]

    public class TarefasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TarefasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Tarefas
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Tarefas.Include(t => t.Tipo);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Tarefas
        [AllowAnonymous]

        public async Tsk<IActionResult>  Index()
        {
            var applicationDbContext = _context.Tarefas.Include(t => t.Tipo);
            return View(await applicationDbContext.ToListAsync());
        }
        