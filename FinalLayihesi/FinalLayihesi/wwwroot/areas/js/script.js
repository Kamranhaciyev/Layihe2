(function ($) {
    "use strict"; // Start of use strict

    CKEDITOR.replace('Content');
    CKEDITOR.replace('Description');

    $('.datepicker').datepicker({
        autoclose: true,
        format: "dd.mm.yyyy"
    });

    let i = 1;

    let prdColorContainer = $("#prdColorContainer");
   /* $(".addNewColorToProduct").on("click", function (e) {
        e.preventDefault();

        $.ajax({
            url: "GetColors/",
            type: "get",
            dataType: "json",
            success: function (response) {
                //console.log(JSON.parse(response));
                let colors = JSON.parse(response)

                let mainDiv = $("<div class='form-inline mt-2'></div>");
                let mainDivColor = $("<div class='form-group mr-1'></div>");
                let mainDivQuantity = $("<div class='form-group mr-1'></div>");
                let mainDivPrice = $("<div class='form-group mr-1'></div>");
                let mainDivDisP = $("<div class='form-group mr-1'></div>");
                let mainDivDisD = $("<div class='form-group mr-1'></div>");

                let colorSelect = $('<select class="form-control" name="ColorToProducts[' + i + '].ColorId"></select>');
                let defOption = $('<option disabled selected value="null">Select color</option>');

                colorSelect.append(defOption);
                for (var j = 0; j < colors.length; j++) {
                    let newOption = $('<option  value="' + colors[j].Id + '">' + colors[j].Name + '</option>');
                    colorSelect.append(newOption);
                }

                let inputQunatity = $('<input class="form-control" name="ColorToProducts[' + i + '].Quantity" placeholder="Quantity">');
                let inputPrice = $('<input class="form-control" name="ColorToProducts[' + i + '].Price" placeholder="Price">');
                let inputDisPrice = $('<input class="form-control" name="ColorToProducts[' + i + '].DiscountPrice" placeholder="Discount Price">');
                let inputDisD = $('<input class="form-control datepicker" autocomplete="off" name="ColorToProducts[' + i + '].DiscountDeadline" placeholder="Discount deadline">');

                mainDivColor.append(colorSelect);
                mainDivQuantity.append(inputQunatity);
                mainDivPrice.append(inputPrice);
                mainDivDisP.append(inputDisPrice);
                mainDivDisD.append(inputDisD);

                mainDiv.append(mainDivColor);
                mainDiv.append(mainDivQuantity);
                mainDiv.append(mainDivPrice);
                mainDiv.append(mainDivDisP);
                mainDiv.append(mainDivDisD);

                prdColorContainer.append(mainDiv);
                i++;
            },
            error: function (response) {
                console.log(response);
            },
            complete: function () {
                var datepicker = $(".datepicker");
                datepicker.datepicker({
                    autoclose: true,
                    format: "dd.mm.yyyy"
                });
            }
        });




    });*/


    //Update images
    $(".updateImage").on("click", function (e) {
        e.preventDefault();
      

        let productId = Number($(".mainImage input[name='id']").val());
        let image = document.getElementsByName("mainImage")[0].files[0];
        var imageFile;
        let reader = new FileReader();

        reader.readAsDataURL(image);
        reader.onloadend = function (e) {
            imageFile = reader.result;
            $.ajax({
                url: "UpdateMainImage/",
                type: "post",
                dataType: "json",
                data: {
                    id: productId,
                    mainImage: imageFile
                },
                success: function (response) {
                    window.location.href = "update?id=" + response;
                
                    //This.nextElementSibling.nextElementSibling.src = "/Uploads/" + response;
                },
                error: function (response) {
                    console.log(response);
                }
            });
        };
    });


    //Update Product images
    $(".updateProductImage").on("click", function (e) {
        e.preventDefault();

        let productId = Number($(this).prev().val());
        let image = this.previousElementSibling.previousElementSibling.files[0];

        if (image == undefined) {
            alert("Ay qa sekil sec");
            return;
        }
        let This = this;

      
        var imageFile;
        let reader = new FileReader();
        reader.readAsDataURL(image);
        reader.onloadend = function (e) {
            imageFile = reader.result;

            $.ajax({
                url: "UpdateProductImage/",
                type: "post",
                dataType: "json",
                data: {
                    id: productId,
                    mainImage: imageFile
                },
                success: function (response) {
                    window.location.href = "update?id=" + response;
                    This.nextElementSibling.nextElementSibling.src = "/Uploads/" + response;
              
                },
                error: function (response) {
                    console.log(response);
                }
            });
        };
    });


    //Delete Product images
    $(".deleteProductImage").on("click", function (e) {
        e.preventDefault();
      

        let productId = Number($(this).prev().prev().val());
        let This = $(this);

            $.ajax({
                url: "DeleteProductImage?id=",
                type: "post",
                dataType: "json",
                data: {
                    id: productId,
                },
                success: function (response) {
                    This.parent().parent().remove();
               
                },
                error: function (response) {
                    console.log(response);
                }
            });
    });

})(jQuery); // End of use strict
