//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TWW.API {
    
    
    public class daPy_fanSwingEcallBack_c {
        
        [System.Text.Json.Serialization.JsonIgnoreAttribute()]
        private u32 pointer;
        
        //public bool mAlphaOutFlg {get => this._mAlphaOutFlg(); set => this._mAlphaOutFlg(value);}//;
        
        //public JPABaseEmitter mpEmitter {get => this._mpEmitter(); set => this._mpEmitter(value);}//;
        
        public daPy_fanSwingEcallBack_c(u32 pointer) {
           this.pointer = pointer;
        }
        
        public static uint getSize() {
          return 0xC;
        }
/*        
        private BOOL _mAlphaOutFlg() {
            return new BOOL(this.pointer + 0x4);
        }
        
        private void _mAlphaOutFlg(BOOL value) {
        }
        
        private JPABaseEmitter _mpEmitter() {
            return new JPABaseEmitter(this.pointer + 0x8);
        }
        
        private void _mpEmitter(JPABaseEmitter value) {
        }*/
    }
}
