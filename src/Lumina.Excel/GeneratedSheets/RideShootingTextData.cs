// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "RideShootingTextData", columnHash: 0xdebb20e3 )]
    public class RideShootingTextData : ExcelRow
    {
        
        public SeString String;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            String = parser.ReadColumn< SeString >( 0 );
        }
    }
}