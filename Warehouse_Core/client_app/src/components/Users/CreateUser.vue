<template>
  <div class="hello">
    <Navbar />
    <div id="content">
      <!-- <h1>{{ msg }}</h1> -->

      <input name="firstName" v-model="Name" placeholder="First Name" />
      <br />
      <input name="lastName" v-model="LastName" placeholder="Last Name" />
      <br />
      <button v-on:click="sendToServer">Submit</button>
    </div>
    <router-view></router-view>
  </div>
</template>

<script>
import Navbar from "./../Navbar";
import axios from 'axios';

export default {
  components: {
    Navbar,
  },
    Name: "",
    LastName: "",
    methods: {
        sendToServer: function () {

            axios({
                    method: 'post',
                    url: '/user/create',
                    data: {
                        "Name": this.Name,
                        "LastName": this.LastName
                    }
                })
                .then(function (response) {
                    console.log(response);
                })
                .catch(function (error) {
                    console.log(error);
                });

        }
    }

}



</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped src="../../assets/style/warehouse_style.css">
</style>


