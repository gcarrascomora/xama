    using System;
    using System.Collections.Generic;
    using Xamarin.Forms;
    using System.Collections.ObjectModel;
    using Xamarin.Forms.Internals;

    namespace holamundo.lista
    {
        public partial class Lista : ContentPage
        {
            public ObservableCollection<Person> collection { get; set; }
            Datos dato = new Datos();
            public Lista()
            {
                InitializeComponent();

                collection = new ObservableCollection<Person>(dato.Persona());
                listadatos.ItemsSource = collection;

            }


            async void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
            {
                if (e.SelectedItem != null)
                {

                var index = (listadatos.ItemsSource as ObservableCollection<Person>).IndexOf(e.SelectedItem as Person);
                    var item = e.SelectedItem;
                    Person person = new Person();
                    person = collection[int.Parse(index.ToString())];
                    System.Console.WriteLine("esto es lo que imprime ");
                    //click(person);
                    var emer = await DisplayAlert("Contactar", person.nombrePersona + " " + person.apellidoPersona + "", "Llamar", "Cancelar");
                    if (emer)
                    {
                        await DisplayAlert("Seguridad", "Esta seguro que desea LLamar", "llamar", "salir");
                    }
                    else
                    {

                    }
                    // DisplayAlert("Item Selected", person.nombrePersona, "Ok");
                    listadatos.SelectedItem = null;

                }
            }
            void click(Person p)
            {

                //.WriteLine("texto"+mess.IsCompleted.ToString());



            }
        }
    }