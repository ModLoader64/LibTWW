//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TWW.API {
    
    
    public class camera_process_class {
        
        [System.Text.Json.Serialization.JsonIgnoreAttribute()]
        private u32 pointer;
        
        //public create_tag_class mDwTg {get => this._mDwTg(); set => this._mDwTg(value);}//;
        
       // public leafdraw_method_class mpMtd {get => this._mpMtd(); set => this._mpMtd(value);}//;
        
        public u8[] field_0x228 {get => this._field_0x228(); set => this._field_0x228(value);}//;
        
        public s8 mPrm1 {get => this._mPrm1(); set => this._mPrm1(value);}//;
        
        public s8 mPrm2 {get => this._mPrm2(); set => this._mPrm2(value);}//;
        
        public s8 mPrm3 {get => this._mPrm3(); set => this._mPrm3(value);}//;
        
        public s8 field_0x22f {get => this._field_0x22f(); set => this._field_0x22f(value);}//;
        
        public csXyz mAngle {get => this._mAngle(); set => this._mAngle(value);}//;
        
        public u32 field_0x238 {get => this._field_0x238(); set => this._field_0x238(value);}//;
        
        public camera_process_class(u32 pointer) {
           this.pointer = pointer;
        }
        
        public static uint getSize() {
          return 0x0; // DEADBEEF TODO: Fix Addr
        }
        
/*        private create_tag_class _mDwTg() {
            return new create_tag_class(this.pointer + 0x210);
        }
        
        private void _mDwTg(create_tag_class value) {
        }
        
        private leafdraw_method_class _mpMtd() {
            return new leafdraw_method_class(this.pointer + 0x224);
        }
        
        private void _mpMtd(leafdraw_method_class value) {
        }*/
        
        // #ARRCOUNT 4
        private u8[] _field_0x228() {
            u8[] bytes = new u8[4]; for(u32 i = 0; i < 4; i++){bytes[i] = Memory.RAM.ReadU8(this.pointer + 0x228 + (i * 1));} return bytes;
        }
        
        private void _field_0x228(u8[] value) {
            for(u32 i = 0; i < 4; i++){Memory.RAM.WriteU8(this.pointer + 0x228 + (i * 1), value[i]);}
        }
        
        private s8 _mPrm1() {
            return Memory.RAM.ReadS8(this.pointer + 0x22C);
        }
        
        private void _mPrm1(s8 value) {
            Memory.RAM.WriteS8(this.pointer + 0x22C, value);
        }
        
        private s8 _mPrm2() {
            return Memory.RAM.ReadS8(this.pointer + 0x22D);
        }
        
        private void _mPrm2(s8 value) {
            Memory.RAM.WriteS8(this.pointer + 0x22D, value);
        }
        
        private s8 _mPrm3() {
            return Memory.RAM.ReadS8(this.pointer + 0x22E);
        }
        
        private void _mPrm3(s8 value) {
            Memory.RAM.WriteS8(this.pointer + 0x22E, value);
        }
        
        private s8 _field_0x22f() {
            return Memory.RAM.ReadS8(this.pointer + 0x22F);
        }
        
        private void _field_0x22f(s8 value) {
            Memory.RAM.WriteS8(this.pointer + 0x22F, value);
        }
        
        private csXyz _mAngle() {
            return new csXyz(this.pointer + 0x230);
        }
        
        private void _mAngle(csXyz value) {
        }
        
        private u32 _field_0x238() {
            return Memory.RAM.ReadU32(this.pointer + 0x238);
        }
        
        private void _field_0x238(u32 value) {
            Memory.RAM.WriteU32(this.pointer + 0x238, value);
        }
    }
}
