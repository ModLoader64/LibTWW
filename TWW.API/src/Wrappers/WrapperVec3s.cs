//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TWW.API {
    
    
    public class WrapperVec3s {
        
        [System.Text.Json.Serialization.JsonIgnoreAttribute()]
        private u32 pointer;
        
        public s16 x {get => this._x(); set => this._x(value);}//;
        
        public s16 y {get => this._y(); set => this._y(value);}//;
        
        public s16 z {get => this._z(); set => this._z(value);}//;
        
        public WrapperVec3s(u32 pointer) {
           this.pointer = pointer;
        }
        
        public static uint getSize() {
          return 0x06;
        }
        
        private s16 _x() {
            return Memory.RAM.ReadS16(this.pointer + 0x00);
        }
        
        private void _x(s16 value) {
            Memory.RAM.WriteS16(this.pointer + 0x00, value);
        }
        
        private s16 _y() {
            return Memory.RAM.ReadS16(this.pointer + 0x02);
        }
        
        private void _y(s16 value) {
            Memory.RAM.WriteS16(this.pointer + 0x02, value);
        }
        
        private s16 _z() {
            return Memory.RAM.ReadS16(this.pointer + 0x04);
        }
        
        private void _z(s16 value) {
            Memory.RAM.WriteS16(this.pointer + 0x04, value);
        }
    }
}
