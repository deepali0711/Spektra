document.querySelector("#files").addEventListener("change", (e) =>
{
if(window.File && window.FileReader && window.FileList && window.Blob)
{
    console.log("yess")
    const files= e.target.files;
    const output = document.querySelector("#Uploaded");


    for(let i = 0; i< files.length;i++)
    {
        if(!files[i].type.match("image"))continue;
        const picReader = new FileReader();
        picReader.addEventListener("load", function(event)
        {
            const picFile =event.target;
            const div = document.createElement("div");
            div.innerHTML = `<img class= "thumbnail" src="${picFile.result}" title= "${picFile.name}"/>
            <div class="btns"><button>Like</button> <input type="text"><button>Comment</button><div>`;
            output.appendChild(div);
        })
        picReader.readAsDataURL(files[i]);
    }
}
else{
    alert("your browser does not support")
}
}
)