
//Load sample data
using MLTest;

var sampleData = new SentimentModel.ModelInput()
{
    Col0 = @"Wow... Loved this place.",
};

//Load model and predict output
var result = SentimentModel.Predict(sampleData);

var sentiment = result.PredictedLabel == 1 ? "Positive" : "Negative";
Console.WriteLine($"Text: {sampleData.Col0}\nSentiment: {sentiment}");