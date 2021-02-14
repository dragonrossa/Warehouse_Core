import Vue from 'vue'
import { BootstrapVue, IconsPlugin } from 'bootstrap-vue'
import App from './App.vue'
import VueRouter from 'vue-router'
import 'bootstrap/dist/css/bootstrap.css'
import 'bootstrap-vue/dist/bootstrap-vue.css'
// import { BNavbar } from 'bootstrap-vue'
// Vue.component('b-navbar', BNavbar)

Vue.use(BootstrapVue)


import Admin from '@/components/Admin'
import Storage from '@/components/Storage'
import Logs from '@/components/Logs'
import Procurement from '@/components/Procurement'
import Search from '@/components/Search'
import Store from '@/components/Store'
import Suppliers from '@/components/Suppliers'
import Task from '@/components/Task'
import Transfers from '@/components/Transfers'
import Users from '@/components/Users'


//Import Store components

import CreateStore from '@/components/Store/CreateStore'
import ListStore from '@/components/Store/ListStore'
import UpdateStore from '@/components/Store/UpdateStore'
import DeleteStore from '@/components/Store/DeleteStore'

//Import Admin components

import EditUser from '@/components/Admin/EditUser'
import Roles from '@/components/Admin/Roles'

//Import Storage components

import CreateItem from '@/components/Storage/CreateItem'
import ListItem from '@/components/Storage/ListItems'
import UpdateItem from '@/components/Storage/UpdateItem'
import DeleteItem from '@/components/Storage/DeleteItem'

//Import Suppliers components

import CreateSupplier from '@/components/Suppliers/CreateSupplier'
import ListSupplier from '@/components/Suppliers/ListSuppliers'
import UpdateSupplier from '@/components/Suppliers/UpdateSupplier'
import DeleteSupplier from '@/components/Suppliers/DeleteSupplier'

//Import Transfers components

import CreateTransfer from '@/components/Transfer/CreateTransfer'
import ListTransfers from '@/components/Transfer/ListTransfers'
import UpdateTransfer from '@/components/Transfer/UpdateTransfer'
import DeleteTransfer from '@/components/Transfer/DeleteTransfer'

//Import Users components

import CreateUser from '@/components/Users/CreateUser'
import ListUsers from '@/components/Users/ListUsers'
import UpdateUsers from '@/components/Users/UpdateUser'
import DeleteUser from '@/components/Users/DeleteUser'

//Import StartPage component

import StartPage from '@/components/StartPage'


Vue.config.productionTip = false


const routes = [
  {path: '/', redirect: '/start', component:StartPage},
  { path: '/admin', name:'admin', component: Admin},
  { path: '/storage', name:'storage', component: Storage},
  { path: '/logs', name:'logs', component: Logs},
  { path: '/procurement', name:'procurement', component:Procurement},
  { path: '/search', name:'search', component: Search},
  { path: '/store', name:'store', component: Store},
  { path: '/suppliers', name:'suppliers', component:Suppliers},
  { path: '/task', name:'task', component: Task},
  { path: '/transfers', name:'transfers', component: Transfers},
  { path: '/users', name:'users', component: Users},
  { path: '/createstore', name:'createstore', component: CreateStore},
  { path: '/liststores', name:'liststores', component: ListStore},
  { path: '/updatestore', name:'updatestore', component: UpdateStore},
  { path: '/deletestore', name:'deletestore', component: DeleteStore},
  { path: '/edituser', name:'edituser', component: EditUser},
  { path: '/roles', name:'roles', component: Roles},
  { path: '/createitem', name:'createitem', component: CreateItem},
  { path: '/listitems', name:'listitems', component: ListItem},
  { path: '/updateitem', name:'updateitem', component: UpdateItem},
  { path: '/deleteitem', name:'deleteitem', component: DeleteItem},
  { path: '/createsupplier', name:'createsupplier', component: CreateSupplier },
  { path: '/listsupplier', name:'listsupplier', component: ListSupplier },
  { path: '/updatesupplier', name:'updatesupplier', component: UpdateSupplier },
  { path: '/deletesupplier', name:'deletesupplier', component: DeleteSupplier },
  { path: 'createtransfer/', name:'createtransfer', component:  CreateTransfer},
  { path: '/listtransfers', name:'listtransfers', component: ListTransfers },
  { path: '/updatetransfer', name:'updatetransfer', component:  UpdateTransfer},
  { path: '/deletetransfer', name:'deletetransfer', component:  DeleteTransfer},
  { path: '/createuser', name:'createuser', component: CreateUser },
  { path: '/listusers', name:'listusers', component: ListUsers },
  { path: '/updateuser', name:'updateuser', component: UpdateUsers },
  { path: '/deleteuser', name:'deleteuser', component: DeleteUser},
  { path: '/back', name:'back', component: StartPage},

]

// 3. Create the router instance and pass the `routes` option
// You can pass in additional options here, but let's
// keep it simple for now.
const router = new VueRouter({
  routes // short for `routes: routes`
})

Vue.use(VueRouter)

new Vue({
  render: h => h(App),
  router
}).$mount('#app')

// Optionally install the BootstrapVue icon components plugin
Vue.use(IconsPlugin)

