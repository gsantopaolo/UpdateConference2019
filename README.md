# AI for every developer - [Update Conference Prague 2019](https://www.updateconference.net/) course material 
Course material for the AI for every developer course.
This is the repository with all the assets out of my speech at the Update Conference 2019 in Prague.
You can find the slides on the [assets folder](https://github.com/gsantopaolo/UpdateConference2019/tree/master/Assets) both in PDF and Power Point format

- [Requirements](https://github.com/gsantopaolo/UpdateConference2019#requirements)
- [Cloning the repository](https://github.com/gsantopaolo/UpdateConference2019#cloning-the-repository)
- [Installing and configuring Anaconda](https://github.com/gsantopaolo/UpdateConference2019#installing-and-configuring-anaconda)
-- Download and Install Anaconda Python 3.7
-- Open an Anaconda prompt and change to course folder
-- Create the course environment
-- Activate the environment
-- Launch Jupyter Notebook
-- Run the Check environment Notebook
-- Troubleshooting installation
-- Updating Conda
- [Samples](https://github.com/gsantopaolo/UpdateConference2019#samples)
-- MNIST_MLdotNet
-- MNIST_TensorFlowdotNet
-- MNIST_KerasdotNet
-- Notebooks
-- MNIST_Client
- [Useful Resources](https://github.com/gsantopaolo/UpdateConference2019#useful-resources)
- [Credits](https://github.com/gsantopaolo/UpdateConference2019#credits)

------
# Requirements
To run all the samples you're gonna need Visual Studio 2017 or 2019 (any version) to run all the .Net related samples.
You also gonna need .Net Core 3.0 installed on your machine.
To run the ONNX converter you need Docker installed on your system.

To run the notebooks and the Python/TensorFlow/Keras related samples you're gonna need Anaconda
------
# Cloning the repository
Open a Bash prompt, move on the parent directory where you want to clone the repository and type the following command on a Bash console:

```
git clone https://github.com/gsantopaolo/UpdateConference2019.git
```
------
# Installing and configuring Anaconda
## Download and Install Anaconda Python 3.7

https://www.anaconda.com/download/

## Open an Anaconda prompt and change to course folder

```
cd UpdateConference2019
```

## Create the course environment
if you want to use the CPU
```
conda env create
```
If you have an NVidia GPU GTX/RTX
```
conda env create -f environment-gpu.yml
```

wait for the environment to create.

## Activate the environment
```
conda activate ai_for_every_dev
```

Check that your prompt changed to

```
(ai_for_every_dev) $
```

## Launch Jupyter Notebook

```
jupyter notebook
```

## Run the Check environment Notebook

Go to the notebooks folder, open the notebook `check_environment.ipynb` and run it. If you see the message:

    Houston we are go!

You are good to go! Enjoy!


## Troubleshooting installation
If for some reason you don't see `Houston we are go!`, the simplest solution is to delete the environment and start from scratch again.

To remove the environment:

- close the browser and go back to your terminal
- stop jupyter notebook (CTRL-C)
- deactivate the environment:

```
conda deactivate
```

- delete the environment:

```
conda env remove -n ai_for_every_dev
```

- restart from environment creation and make sure that each steps completes till the end.

## Updating Conda

One thing you can also try is to update your conda executable. This may help if you already had Anaconda installed on your system.

```
conda update conda
```
------
# Samples
## MNIST_MLdotNet
Contains the sample demonstrating how to create the MNIST 

## MNIST_TensorFlowdotNet

## MNIST_KerasdotNet

## Notebooks

## MNIST_Client
------
# Useful Resources
- [Book] Make Your Own Neural Network - Rashid, Tariq 
- [Book] Deep Learning with Python - Chollet, Francois
- [Book] Andrew Glassner   - [Deep Learning, Vol. 1: From Basics to Practice](https://www.amazon.com/dp/B079XSQNRX/)
- [Book] Yaser S. Abu-Mostafa – [Learning from data](https://www.amazon.com/Learning-Data-Yaser-S-Abu-Mostafa/dp/1600490069)  (inside the book instruction to access whole semester course gave by prof. Yaser S. Abu-Mostafa  at California Institute of Technology)
- [Video] Andrew Glassner – [Deep Learning: A crash Course](https://www.youtube.com/watch?v=r0Ogt-q956I ) 
- MIT - Massachusetts Institute of Technology – Professional Certificate Program in Machine Learning & Artificial Intelligence
- Microsoft’s official [AI site for devs](https://azure.microsoft.com/en-us/overview/ai-platform/) 
- Microsoft’s [AI School](https://aischool.microsoft.com/en-us/learning-paths ) 
- [Video] Jason Mayers – [Machine Learning in 45 Minutes](https://www.youtube.com/watch?v=X4I9QmcSEYo)  
- [Video] Chris Lauren – Seth Juarez - [Demystifying Machine and Deep Learning for - Developers](https://www.youtube.com/watch?v=cU7Wq5k8u-U)  
- [Introducing ML.NET](https://www.youtube.com/watch?v=OhCysVU5RDA ) 
- [ONNX](https://onnx.ai/) 
- [ONNX Model Zoo](https://github.com/onnx/models)  
- [ONNX models for WinML](https://docs.microsoft.com/en-us/windows/ai/get-onnx-model)  
- [Azure AI Gallery](https://gallery.azure.ai/models ) curates models for use with Windows ML 
- [Ml .Net Samples](https://github.com/dotnet/machinelearning-samples)  
- [Video series] [CH9 – AI Show](https://channel9.msdn.com/Shows/AI-Show) 
- [The MNIST Database](http://yann.lecun.com/exdb/mnist/ ) 
- [Kaggle Datasets database](https://www.kaggle.com/datasets)  
- [Getting started with TensorFlow](https://tf.wiki/en/basic.html ) 
- [TensorFlow model zoo](https://github.com/tensorflow/models/blob/master/research/object_detection/g3doc/detection_model_zoo.md ) 
- [Cafee model zoo](https://github.com/BVLC/caffe/wiki/Model-Zoo)   
- Christopher Olah’s blog about DL http://colah.github.io/ 


------

# Credits

Special thanks to the following people and groups that contributed inspiration, ideas or support for this ever-evolving talk / workshop:
- [Jason Mayes](https://twitter.com/jason_mayes)
- [Rick Barraza](https://twitter.com/rickbarraza)
- [Seth Juarez](https://twitter.com/sethjuarez)
- [Ankit](https://twitter.com/ankitasthana86)
- [Chris Olah](https://twitter.com/ch402)	 
- [The Asimov Institute](http://www.asimovinstitute.org/)
- [Andrew Glassner](https://twitter.com/andrewglassner)
- [The Emerging Experiences friends](https://emerging-experiences.slack.com/)
-- Andras Velvart
-- Andreas Erben
-- Bronwen Zande
-- David Renton
-- Dennis Vroegop
-- Dwight Goins
-- Gordon McTaco
-- James Ashley
-- Jasper Brekelmans
-- Joshua Blake
-- Tim Huckaby
-- Vincent Guigui
