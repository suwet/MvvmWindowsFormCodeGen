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

namespace TestConsumeGenCode.Views
{
    public partial class EditMUserForm : Form,IViewFor<MUserViewModel>
    {
        private MUserViewModel _MUserViewModel;
        private MUserService _service = new MUserService();

        public EditMUserForm()
        {
            InitializeComponent();

            _MUserViewModel = new MUserViewModel();

            var first_object = _service.GetAll().FirstOrDefault();
            
            // text box two way bind 
            if(first_object!=null)
            {
                _MUserViewModel = first_object;
                    
   this.Bind(_MUserViewModel,(vm)=> vm.CF_Name,(v)=> v.txt_cf_name.Text);
    
   this.Bind(_MUserViewModel,(vm)=> vm.CF_Value,(v)=> v.txt_cf_value.Text);
    
   this.Bind(_MUserViewModel,(vm)=> vm.CF_Group,(v)=> v.txt_cf_group.Text);
    
   this.Bind(_MUserViewModel,(vm)=> vm.CF_Description,(v)=> v.txt_cf_description.Text);

            }
        }

        public MUserViewModel ViewModel 
        {
            get => _MUserViewModel;
            set => _MUserViewModel = value;
        }
        object IViewFor.ViewModel { 
            get => _MUserViewModel;
            set => _MUserViewModel = (MUserViewModel)value;
        }
    }
}
