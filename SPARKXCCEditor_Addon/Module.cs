using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMTSpark.Properties;
using M64MM.Additions;

namespace CMTSpark
{
    class Module : IModule
    {

        AppearanceForm af;

        public string SafeName => "SPARK Color Code Editor";

        public string Description => "X3 Mario (and future SPARK/X4 mods) now have Color Codes!";

        public Image AddonIcon => Resources.spark_;

        public void Close(EventArgs e)
        {

        }

        public List<ToolCommand> GetCommands()
        {
            List<ToolCommand> tcl = new List<ToolCommand>();
            ToolCommand tc = new ToolCommand("Open SPARK Studio");
            tc.Summoned += (a, b) => ShowForm();
            tcl.Add(tc);
            return tcl;
        }


        void ShowForm()
        {
            if (af == null)
            {
                af = new AppearanceForm();
            }
            af.Show();
        }

        public void Initialize()
        {

        }

        public void OnBaseAddressFound()
        {

        }

        public void OnBaseAddressZero()
        {

        }

        public void Reset()
        {

        }

        public void Update()
        {
            if (af != null)
            {
                if (af.canRandom)
                {
                    af.ExecuteRandomCC();
                }
            }
        }

        public void OnCoreEntAddressChange(uint addr)
        {
            throw new NotImplementedException();
        }
    }
}
