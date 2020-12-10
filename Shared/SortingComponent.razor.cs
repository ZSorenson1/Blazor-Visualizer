using Microsoft.AspNetCore.Components;
using Blazor_Visualizer.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Blazor_Visualizer.Shared 
{
    public class SortingComponentBase : ComponentBase
    {
        [Inject]
        public SortingComponentBase sortComponent {get; set;}

        public int[] arr = new int[10];

        public bool bubbleSort = false;
        public bool mergeSort = false;

        public async Task OnNotifyDataChanged()
        {
            await InvokeAsync(() => 
            {
                StateHasChanged();
            });
        }

        protected override void OnInitialized()
        {
            FillArray();
            sortComponent.OnChange += StateHasChanged;
        }

        public void UpdateUI()
        {
            NotifyDataChanged();
        }

        public async void RunSort()
        {
            if (bubbleSort)
            {
                bubbleSort = false;
                BubbleSortClass bubbleSortClass = new BubbleSortClass();
                await bubbleSortClass.BubbleSort(arr);
            }
            if (mergeSort)
            {
                mergeSort = false;
                
            }
        }
        public void FillArray()
        {
            Random rand = new Random();
            for(int i=0; i<arr.Length; i++){
                arr[i] = rand.Next(5, 1000);
            }
            NotifyDataChanged();
        }

        public event Action OnChange;

        private void NotifyDataChanged() => OnChange?.Invoke();
    }
}

