//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TWW.API {
    
    
    public class dSv_player_status_b_c {
        
        [System.Text.Json.Serialization.JsonIgnoreAttribute()]
        private u32 pointer;
        
        public u64 mDateIPL {get => this._mDateIPL(); set => this._mDateIPL(value);}//;
        
        public f32 field_0x8 {get => this._field_0x8(); set => this._field_0x8(value);}//;
        
        public f32 mTime {get => this._mTime(); set => this._mTime(value);}//;
        
        public u16 mDate {get => this._mDate(); set => this._mDate(value);}//;
        
        public s16 mTactWindAngleX {get => this._mTactWindAngleX(); set => this._mTactWindAngleX(value);}//;
        
        public s16 mTactWindAngleY {get => this._mTactWindAngleY(); set => this._mTactWindAngleY(value);}//;
        
        public dSv_player_status_b_c(u32 pointer) {
           this.pointer = pointer;
        }
        
        public static uint getSize() {
          return 0x18;
        }
        
        private u64 _mDateIPL() {
            return Memory.RAM.ReadU64(this.pointer + 0x00);
        }
        
        private void _mDateIPL(u64 value) {
            Memory.RAM.WriteU64(this.pointer + 0x00, value);
        }
        
        private f32 _field_0x8() {
            return Memory.RAM.ReadF32(this.pointer + 0x08);
        }
        
        private void _field_0x8(f32 value) {
            Memory.RAM.WriteF32(this.pointer + 0x08, value);
        }
        
        private f32 _mTime() {
            return Memory.RAM.ReadF32(this.pointer + 0x0C);
        }
        
        private void _mTime(f32 value) {
            Memory.RAM.WriteF32(this.pointer + 0x0C, value);
        }
        
        private u16 _mDate() {
            return Memory.RAM.ReadU16(this.pointer + 0x10);
        }
        
        private void _mDate(u16 value) {
            Memory.RAM.WriteU16(this.pointer + 0x10, value);
        }
        
        private s16 _mTactWindAngleX() {
            return Memory.RAM.ReadS16(this.pointer + 0x12);
        }
        
        private void _mTactWindAngleX(s16 value) {
            Memory.RAM.WriteS16(this.pointer + 0x12, value);
        }
        
        private s16 _mTactWindAngleY() {
            return Memory.RAM.ReadS16(this.pointer + 0x14);
        }
        
        private void _mTactWindAngleY(s16 value) {
            Memory.RAM.WriteS16(this.pointer + 0x14, value);
        }
        
    }
}