using FruitApp.Models;

namespace FruitApp;

public partial class MainPage : ContentPage
{

    List<FruitModel> fruits = new List<FruitModel>(){
         new FruitModel("Apple","apple.png","An apple a day keeps the doctor away."),
           new FruitModel("Apricot","apricot.png","We had apricot trees in the back and side yard of the property."),
           new FruitModel("Banana","banana.png","The world is a better place when we share a banana split with someone we love."),
           new FruitModel("Grape","grapes.png","I really do not like grapes if they are not seedless."),
           new FruitModel("Guava","guava.png","On either side of the road are groves of guava trees."),
           new FruitModel("Kiwi","kiwi.png","Life is too short to waste on a bad kiwi"),
           new FruitModel("Mango","mango.png","Happiness is a ripe, juicy mango on a sunny day."),
           new FruitModel("Orange","orange.png","Oranges are not the only fruit, but they sure are a delicious one."),
           new FruitModel("Peach","peach.png","Although my mom cannot touch peaches, she washed and sliced peach for me."),
           new FruitModel("Pineapple","pineapple.png","It was a mystery that how that pineapple came to the student center without nobody moving it."),
           new FruitModel("Strawberry","strawberry.png","Emma does not love yogurt itself, but she eats strawberry yogurt every day."),
           new FruitModel("Watermelon","watermelon.png","My favorite summer fruit is watermelon, I love eating it when it is cold.") };
    public MainPage()
    {
        InitializeComponent();
        LVFruits.ItemsSource = fruits;
    }
    protected void LVFruits_ItemSelectedChanged(object sender, SelectionChangedEventArgs e)
    {
        var fruit = e.CurrentSelection.FirstOrDefault() as FruitModel;
        if (fruit == null)
            return;
        Navigation.PushAsync(new FruitInfo(fruit));
        ((CollectionView)sender).SelectedItem = null;
    }
    //protected void LVFruits_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    //{
    //    var fruit = e.SelectedItem as FruitModel;
    //    if (fruit == null)
    //        return;
    //    Navigation.PushAsync(new FruitInfo(fruit));
    //    ((ListView)sender).SelectedItem = null;
    //}

}

