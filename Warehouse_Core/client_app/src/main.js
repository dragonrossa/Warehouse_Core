import Vue from 'vue'
import App from './App.vue'
import VueRouter from 'vue-router'
import { BootstrapVue, IconsPlugin } from 'bootstrap-vue'

// Import Bootstrap an BootstrapVue CSS files (order is important)
import 'bootstrap/dist/css/bootstrap.css'
import 'bootstrap-vue/dist/bootstrap-vue.css'

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

Vue.config.productionTip = false


const routes = [
  { path: '/admin', name:'admin', component: Admin },
  { path: '/storage', name:'storage', component: Storage },
  { path: '/logs', name:'logs', component: Logs },
  { path: '/procurement', name:'procurement', component:Procurement  },
  { path: '/search', name:'search', component: Search  },
  { path: '/store', name:'store', component: Store },
  { path: '/suppliers', name:'suppliers', component:Suppliers  },
  { path: '/task', name:'task', component: Task  },
  { path: '/transfers', name:'transfers', component: Transfers  },
  { path: '/users', name:'users', component: Users  },
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

Vue.use(BootstrapVue)
// Optionally install the BootstrapVue icon components plugin
Vue.use(IconsPlugin)

