//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TWW.API {
    
    
    public class dSv_zoneBit_c {
        
        [System.Text.Json.Serialization.JsonIgnoreAttribute()]
        private u32 pointer;
        
        public u16[] mSwitch {get => this._mSwitch(); set => this._mSwitch(value);}//;
        
        public u16 mItem {get => this._mItem(); set => this._mItem(value);}//;
        
        public dSv_zoneBit_c(u32 pointer) {
           this.pointer = pointer;
        }
        
        public static uint getSize() {
          return 0x8;
        }
        
        // #ARRCOUNT 3
        private u16[] _mSwitch() {
            u16[] bytes = new u16[3]; for(u32 i = 0; i < 3; i++){bytes[i] = Memory.RAM.ReadU16(this.pointer + 0x0 + (i * 2));} return bytes;
        }
        
        private void _mSwitch(u16[] value) {
            for(u32 i = 0; i < 3; i++){Memory.RAM.WriteU16(this.pointer + 0x0 + (i * 2), value[i]);}
        }
        
        private u16 _mItem() {
            return Memory.RAM.ReadU16(this.pointer + 0x6);
        }
        
        private void _mItem(u16 value) {
            Memory.RAM.WriteU16(this.pointer + 0x6, value);
        }
    }
}
