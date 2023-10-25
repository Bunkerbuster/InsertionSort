using InsertionSortServices;
using Microsoft.AspNetCore.Mvc;

namespace InsertionSort.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InsertionSortController : ControllerBase
    {

        private readonly int[] _UnsortedArray = new[] { 64, 34, 25, 12, 22, 11, 90 };

        private readonly IInsertionSortAlgorithm _IInsertionSortAlgorithm;

        private readonly ILogger<InsertionSortController> _logger;

        public InsertionSortController
        (
            ILogger<InsertionSortController> logger,
            IInsertionSortAlgorithm _Iinsertionsortalgorithm
        )
        {
            _logger = logger;
            _IInsertionSortAlgorithm = _Iinsertionsortalgorithm;
        }

        [HttpGet("PrintUnsortedArray")]
        public async Task<ActionResult> PrintUnsortedArray()
        {
            return Ok( _UnsortedArray );
        }


        [HttpGet("PrintSortedArray")]
        public async Task<ActionResult> PrintSortedArray()
        {
            var _SortedArray = _IInsertionSortAlgorithm.SortArray(_UnsortedArray);

            return Ok( _SortedArray );
        }
    }
}