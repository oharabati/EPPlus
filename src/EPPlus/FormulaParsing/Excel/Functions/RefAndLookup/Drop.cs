﻿/*************************************************************************************************
  Required Notice: Copyright (C) EPPlus Software AB. 
  This software is licensed under PolyForm Noncommercial License 1.0.0 
  and may only be used for noncommercial purposes 
  https://polyformproject.org/licenses/noncommercial/1.0.0/

  A commercial license to use this software can be purchased at https://epplussoftware.com
 *************************************************************************************************
  Date               Author                       Change
 *************************************************************************************************
  01/27/2020         EPPlus Software AB       Initial release EPPlus 5
 *************************************************************************************************/
using OfficeOpenXml.FormulaParsing.Excel.Functions.Metadata;
using OfficeOpenXml.FormulaParsing.FormulaExpressions;
using OfficeOpenXml.FormulaParsing.LexicalAnalysis;
using OfficeOpenXml.FormulaParsing.Ranges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OfficeOpenXml.FormulaParsing.Excel.Functions.RefAndLookup
{
    [FunctionMetadata(
        Category = ExcelFunctionCategory.LookupAndReference,
        EPPlusVersion = "7",
        Description = "Excludes a specified number of rows or columns from the start or end of an array")]
    internal class Drop : ExcelFunction
    {
        public override CompileResult Execute(IEnumerable<FunctionArgument> arguments, ParsingContext context)
        {
            ValidateArguments(arguments, 2);
            var firstArg = arguments.First();
            int rows, cols;
            rows = ArgToInt(arguments, 1);
            if (arguments.Count() > 2)
            {
                cols = ArgToInt(arguments, 2);
            }
            else
            {
                cols = 0;
            }

            if(firstArg.DataType == DataType.ExcelRange)
            {
                var r = firstArg.Value as IRangeInfo;
                if(r.Size.NumberOfRows <= Math.Abs(rows) || r.Size.NumberOfCols <= Math.Abs(cols))
                {
                    return CompileResult.GetErrorResult(eErrorType.Calc);
                }

                int fromRow, fromCol, toRow, toCol;

                if(rows<0)
                {
                    fromRow = r.Address.FromRow;
                    toRow = r.Address.ToRow+rows;
                }
                else
                {
                    fromRow = r.Address.FromRow + rows;
                    toRow = r.Address.ToRow;
                }

                if(cols<0)
                {
                    fromCol = r.Address.FromCol;
                    toCol = r.Address.ToCol + cols;
                }
                else
                {
                    fromCol = r.Address.FromCol + cols;
                    toCol = r.Address.ToCol;
                }

                
                IRangeInfo retRange;
                if(r.IsInMemoryRange)
                {
                    retRange = r.GetOffset(fromRow, fromCol, toRow, toCol);
                    return CreateResult(retRange, DataType.ExcelRange);
                }
                else
                {
                    var address = new FormulaRangeAddress(context, fromRow, fromCol, toRow, toCol);
                    retRange = new RangeInfo(r.Worksheet, fromRow, fromCol, toRow, toCol, context, r.Address.ExternalReferenceIx); //External references must be check how they work.
                    return CreateResult(retRange, DataType.ExcelRange, address);
                }
            }
            // arg was not a range
            if(rows == 0 && cols == 0)
            {
                return CompileResultFactory.Create(firstArg.Value);
            }
            return CompileResult.GetErrorResult(eErrorType.Calc);
            
        }
        public override string NamespacePrefix => "_xlfn.";
        public override bool ReturnsReference => true;        
    }
}