using Microsoft.AspNetCore.Mvc;
using ChessApi.Models;
using System.Collections.Generic;

namespace ChessApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChessController : ControllerBase
    {
        [HttpGet("initial")]
        public IActionResult GetInitialPositions()
        {
            var pieces = new List<ChessPiece>
            {
                new ChessPiece { Col = 0, Row = 0, Type = "Rook", Color = "Black" },
                new ChessPiece { Col = 0, Row = 1, Type = "Knight", Color = "Black" },
                new ChessPiece { Col = 0, Row = 2, Type = "Bishop", Color = "Black" },
                new ChessPiece { Col = 0, Row = 3, Type = "Queen", Color = "Black" },
                new ChessPiece { Col = 0, Row = 4, Type = "King", Color = "Black" },
                new ChessPiece { Col = 0, Row = 5, Type = "Bishop", Color = "Black" },
                new ChessPiece { Col = 0, Row = 6, Type = "Knight", Color = "Black" },
                new ChessPiece { Col = 0, Row = 7, Type = "Rook", Color = "Black" },
                new ChessPiece { Col = 1, Row = 0, Type = "Pawn", Color = "Black" },
                new ChessPiece { Col = 1, Row = 1, Type = "Pawn", Color = "Black" },
                new ChessPiece { Col = 1, Row = 2, Type = "Pawn", Color = "Black" },
                new ChessPiece { Col = 1, Row = 3, Type = "Pawn", Color = "Black" },
                new ChessPiece { Col = 1, Row = 4, Type = "Pawn", Color = "Black" },
                new ChessPiece { Col = 1, Row = 5, Type = "Pawn", Color = "Black" },
                new ChessPiece { Col = 1, Row = 6, Type = "Pawn", Color = "Black" },
                new ChessPiece { Col = 1, Row = 7, Type = "Pawn", Color = "Black" },

                new ChessPiece { Col = 6, Row = 0, Type = "Pawn", Color = "White" },
                new ChessPiece { Col = 6, Row = 1, Type = "Pawn", Color = "White" },
                new ChessPiece { Col = 6, Row = 2, Type = "Pawn", Color = "White" },
                new ChessPiece { Col = 6, Row = 3, Type = "Pawn", Color = "White" },
                new ChessPiece { Col = 6, Row = 4, Type = "Pawn", Color = "White" },
                new ChessPiece { Col = 6, Row = 5, Type = "Pawn", Color = "White" },
                new ChessPiece { Col = 6, Row = 6, Type = "Pawn", Color = "White" },
                new ChessPiece { Col = 6, Row = 7, Type = "Pawn", Color = "White" },
                new ChessPiece { Col = 7, Row = 0, Type = "Rook", Color = "White" },
                new ChessPiece { Col = 7, Row = 1, Type = "Knight", Color = "White" },
                new ChessPiece { Col = 7, Row = 2, Type = "Bishop", Color = "White" },
                new ChessPiece { Col = 7, Row = 3, Type = "Queen", Color = "White" },
                new ChessPiece { Col = 7, Row = 4, Type = "King", Color = "White" },
                new ChessPiece { Col = 7, Row = 5, Type = "Bishop", Color = "White" },
                new ChessPiece { Col = 7, Row = 6, Type = "Knight", Color = "White" },
                new ChessPiece { Col = 7, Row = 7, Type = "Rook", Color = "White" }
            };

            return Ok(pieces);
        }
    }
}
