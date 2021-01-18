using LacosDaGI.DataModels;
using LacosDaGI.DbContext;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xamarians.CropImage;
using Xamarin.Essentials;

namespace LacosDaGI.Models
{
    public partial class TieCreateViewModel
    {
        public AsyncCommand<EventArgs> CreateTieCommand { get; set; }
        public AsyncCommand<EventArgs> PickImageCommand { get; set; }
        public RelayCommand<EventArgs> ResetFieldsCommand { get; set; }

        private void InitializeMethods()
        {
            CreateTieCommand = new AsyncCommand<EventArgs>(CreateTie);
            PickImageCommand = new AsyncCommand<EventArgs>(PickImage);
            ResetFieldsCommand = new RelayCommand<EventArgs>(ResetFields);
        }

        private async Task PickImage(EventArgs arg)
        {
            var options = new PickOptions { FileTypes = FilePickerFileType.Images };
            var result = await FilePicker.PickAsync(options);

            if (result != null)
            {
                var cropResult = await CropImageService.Instance.CropImage(result.FullPath, CropRatioType.None);
                if (cropResult.IsSuccess)
                    Image = File.ReadAllBytes(cropResult.FilePath);
            }
        }

        private async Task CreateTie(EventArgs arg)
        {
            if (string.IsNullOrEmpty(Name))
                await ShowDialog("Aviso", "O nome do laço não pode ficar em branco!");
            else if (string.IsNullOrEmpty(Description))
                await ShowDialog("Aviso", "A descrição do laço não pode ficar em branco!");
            else if (Image == null)
                await ShowDialog("Aviso", "A imagem do laço não pode ficar em branco!");
            else
            {
                using (var context = new TiesContext())
                {
                    var tie = new Tie
                    {
                        Name = Name,
                        Description = Description,
                        Image = Image
                    };

                    await context.Ties.AddAsync(tie);
                    await context.SaveChangesAsync();
                }

                await ShowDialog("Sucesso", "O laço foi cadastrado com sucesso!");
                await Navigation.PopAsync();
            }
        }

        private void ResetFields(EventArgs obj)
        {
            Name = string.Empty;
            Description = string.Empty;
            Image = null;
        }
    }
}
