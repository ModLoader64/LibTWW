//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TWW.API {
    
    
    public class dSv_ocean_c {
        
        [System.Text.Json.Serialization.JsonIgnoreAttribute()]
        private u32 pointer;
        
        public u16[] field_0x0 {get => this._field_0x0(); set => this._field_0x0(value);}//;
        
        public dSv_ocean_c(u32 pointer) {
           this.pointer = pointer;
        }
        
        public static uint getSize() {
          return 0x0; // DEADBEEF TODO: Fix Addr
        }
        
        // #ARRCOUNT 50
        private u16[] _field_0x0() {
            u16[] bytes = new u16[50]; for(u32 i = 0; i < 50; i++){bytes[i] = Memory.RAM.ReadU16(this.pointer + 0x0 + (i * 2));} return bytes;
        }
        
        private void _field_0x0(u16[] value) {
            for(u32 i = 0; i < 50; i++){Memory.RAM.WriteU16(this.pointer + 0x0 + (i * 2), value[i]);}
        }
    }
}
