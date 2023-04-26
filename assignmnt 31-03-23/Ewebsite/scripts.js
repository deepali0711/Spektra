var count=0;
            let addCarts=document.querySelectorAll('.add-cart');
            console.log(addCarts)
            for(let i=0;i<addCarts.length;i++){
              addCarts[i].addEventListener('click',() =>{
              
                count+=1;
                var len=document.getElementById('cartLength');
                len.innerText=count;
                
              })
            }