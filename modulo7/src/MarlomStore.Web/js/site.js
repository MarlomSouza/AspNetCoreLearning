// Write your JavaScript code.
$(function() {
  console.log("oi");
});
function formOnFail(error) {
  if (error.status == 500) toastr.error(error.responseText);
}
