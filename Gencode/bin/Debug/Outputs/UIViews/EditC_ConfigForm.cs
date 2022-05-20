using ReactiveUI;
using Rmx.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rmx.Views
{
    public partial class EditC_ConfigForm : Form,IViewFor<CConfigViewModel>
    {
        private CConfigViewModel _CConfigViewModel;
        private CConfigService _service = new CConfigService();

        public EditC_ConfigForm()
        {
            InitializeComponent();

            _CConfigViewModel = new CConfigViewModel();

            var first_object = _service.GetAll().FirstOrDefault();
            
            // text box two way bind 
            if(first_object!=null)
            {
                _CConfigViewModel = first_object;
                    
   this.Bind(_CConfigViewModel,(vm)=> vm.CF_Name,(v)=> v.txt_cf_name.Text);
    
   this.Bind(_CConfigViewModel,(vm)=> vm.CF_Value,(v)=> v.txt_cf_value.Text);
    
   this.Bind(_CConfigViewModel,(vm)=> vm.CF_Group,(v)=> v.txt_cf_group.Text);
    
   this.Bind(_CConfigViewModel,(vm)=> vm.CF_Description,(v)=> v.txt_cf_description.Text);

            }
        }

        public CConfigViewModel ViewModel 
        {
            get => _CConfigViewModel;
            set => _CConfigViewModel = value;
        }
        object IViewFor.ViewModel { 
            get => _CConfigViewModel;
            set => _CConfigViewModel = (CConfigViewModel)value;
        }
    }
}
