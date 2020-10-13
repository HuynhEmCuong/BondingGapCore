using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.Drawing;

namespace BondingGapAPI.Utilities
{
    public static class ExcelUtility
    {
        #region Insert_RichText dùng thằng này khi muốn xuống dòng tự động trong 1 row để đúng kích cỡ của dữ liệu
        /// <summary>
        /// Thêm một ô cho excel
        /// </summary>
        /// <param name="worksheet"> Truyền ExcelWorksheet đang thực thi vào. </param>
        /// <param name="Value"> Giá trị text cần thực thi. </param>
        /// <param name="IndexRow"> Chỉ số dòng cần thêm. </param>
        /// <param name="IndexColumn"> Chỉ số cột cần thêm. </param>
        /// <param name="isBold"> Có in đậm hay không không. </param>
        /// <param name="isCenterText"> Có canh giữa dòng hay không. </param>
        /// <param name="isWrapText"> Có tự động dãn chiều cao dòng theo chiều cao chữ hay không. </param>
        /// <param name="textColor">Màu chữ. Mặc định màu đen. </param>
        /// <param name="backgroundColor">Màu nền . Mặc định màu trắng. </param>
        /// <param name="fontSize"> Kích cỡ chữ . Mặc định 12. </param>
        public static void Insert_RichText(ref ExcelWorksheet worksheet, int IndexRow, int IndexColumn, string Value, bool isBold, bool isCenterText = false, bool isWrapText = true, Color textColor = default(Color), Color backgroundColor = default(Color), int fontSize = 12)
        {
            worksheet.Cells[IndexRow, IndexColumn].Value = Value;

            worksheet.Cells[IndexRow, IndexColumn].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

            //ExcelRichText richText = worksheet.Cells[IndexRow, IndexColumn].RichText.Add(Value);
            //if (isRed)
            //{
            //    richText.Bold = false;
            //    richText.Italic = false;
            //    richText.Color = Color.Red;
            //    richText.FontName = "Arial Narrow";
            //}
            //else
            //{
            //    if (object.Equals(textColor, default(Color))) textColor = Color.Black;
            //    richText.Color = textColor;
            //}


            if (object.Equals(textColor, default(Color))) textColor = Color.Black;
            worksheet.Cells[IndexRow, IndexColumn].Style.Font.Color.SetColor(textColor);

            if (object.Equals(backgroundColor, default(Color))) backgroundColor = Color.White;
            // Set PatternType
            worksheet.Cells[IndexRow, IndexColumn].Style.Fill.PatternType = ExcelFillStyle.Solid;
            // Set color  Background
            worksheet.Cells[IndexRow, IndexColumn].Style.Fill.BackgroundColor.SetColor(backgroundColor);

            if (isCenterText)
            {
                // Canh giữa cho các text
                worksheet.Cells[IndexRow, IndexColumn].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            }
            else worksheet.Cells[IndexRow, IndexColumn].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;

            //worksheet.Cells[IndexRow, IndexColumn].Style.Font.SetFromFont(new Font("Arial", fontSize));
            worksheet.Cells[IndexRow, IndexColumn].Style.Font.Size = fontSize;
            //richText.Size = fontSize;

            worksheet.Cells[IndexRow, IndexColumn].Style.WrapText = isWrapText;
            //worksheet.Cells[IndexRow, IndexColumn].IsRichText = true;

            worksheet.Cells[IndexRow, IndexColumn].Style.Font.Bold = isBold;
            //worksheet.Row(IndexRow).PageBreak = true;
            //worksheet.Column(IndexColumn).PageBreak = true;
            worksheet.Row(IndexRow).Height = 20;

            //Auto height row
            worksheet.Row(IndexRow).CustomHeight = false;
        }
        #endregion

        #region Insert_Table_Column
        /// <summary>
        /// Thêm một cột table 
        /// </summary>
        /// <param name="worksheet"> Truyền ExcelWorksheet đang thực thi vào. </param>
        /// <param name="Value"> Giá trị text cần thực thi. </param>
        /// <param name="IndexRow"> Chỉ số dòng cần thêm. </param>
        /// <param name="IndexColumn"> Chỉ số cột cần thêm. </param>
        /// <param name="isBold"> Có in đậm hay không không. </param>
        public static void Insert_Table_Column(ref ExcelWorksheet worksheet, int IndexRow, int IndexColumn, object Value, bool isCenter = false, bool isBold = false)
        {
            worksheet.Cells[IndexRow, IndexColumn].Value = Value;
            worksheet.Cells[IndexRow, IndexColumn].Style.Font.Bold = isBold;
            worksheet.Cells[IndexRow, IndexColumn].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
            worksheet.Cells[IndexRow, IndexColumn].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
            if (isCenter)
                worksheet.Cells[IndexRow, IndexColumn].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            worksheet.Cells[IndexRow, IndexColumn].Style.Font.Color.SetColor(System.Drawing.Color.Black);
            worksheet.Cells[IndexRow, IndexColumn].Style.WrapText = true;
            worksheet.Cells[IndexRow, IndexColumn].Style.Border.BorderAround(ExcelBorderStyle.Thin);
        }
        #endregion

        #region Set_Cell_Border
        /// <summary>
        /// Thêm border cho table excel 
        /// </summary>
        /// <param name="worksheet"> Truyền ExcelWorksheet đang thực thi vào. </param>
        /// <param name="IndexRow"> Chỉ số dòng cần thêm. </param>
        /// <param name="IndexColumn"> Chỉ số cột cần thêm. </param>
        public static void Set_Cell_Border(ref ExcelWorksheet worksheet, int IndexRow, int IndexColumn)
        {
            worksheet.Cells[IndexRow, IndexColumn].Style.Border.BorderAround(ExcelBorderStyle.Thin);
        }
        #endregion

        #region Merge_Cell
        /// <summary>
        /// Gộp dòng , gộp cột trong excel 
        /// </summary>
        /// <param name="worksheet"> Truyền ExcelWorksheet đang thực thi vào. </param>
        /// <param name="FromRow"> Bắt đầu gộp từ dòng thứ mấy.  </param>
        /// <param name="FromColumn"> Bắt đàu gộp từ cột thứ mấy. </param>
        /// <param name="ToRow"> Kết thức gộp ở dòng thứ mấy. </param>
        /// <param name="ToColumn"> Kết thúc gộp ở cột thứ mấy. </param>
        public static void Merge_Cell(ref ExcelWorksheet worksheet, int FromRow, int FromColumn, int ToRow, int ToColumn)
        {
            worksheet.Cells[FromRow, FromColumn, ToRow, ToColumn].Merge = true;
        }
        #endregion
    }
}
